using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SnakeProject
{
    public partial class SnakeGame : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect, // x-coordinate of upper-left corner
           int nTopRect, // y-coordinate of upper-left corner
           int nRightRect, // x-coordinate of lower-right corner
           int nBottomRect, // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );

        private const string SCORES_FILENAME = @"../../data/scores.xml";

        private int WIDTH = 20;
        private int HEIGHT = 20;
        private int SPEED = 20;
        private int NB_WALLS_INIT = 15;
        private int NB_FOODS_INIT = 5;


        private Snake snake;
        private List<Wall> walls = new List<Wall>();
        private List<Food> foods = new List<Food>();

        private int score;
        private bool gameOver;


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public SnakeGame()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 10, 10));


            StartTab st = new StartTab();
            st.TopLevel = false;
            st.AutoScroll = true;
            resetTabs();
            contentPanel.Controls.Add(st);
            st.Show();
        }

        public void draw(object sender, EventArgs e)
        {
            if (this.gameOver == false)
            {


                boxPseudo.Show();
                labelSave.Show();
                labelSaveName.Show();

                labelSaveOk.Hide();

                this.snake.nextStep(this.SPEED);
                this.gamePanel.Invalidate();

                checkBorders();
                checkEat();
                checkWall();
                checkItself();

            }
            else
            {

                this.gameOverPanel.Show();
                this.labelEndScore.Text = this.labelScore.Text;

            }
        }



        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;

            Brush brush = new SolidBrush(Color.DarkGreen);
            Brush brush_wall = new SolidBrush(Color.Blue);
            Brush brush_food = new SolidBrush(Color.IndianRed);

            this.snake.pixels.ForEach((pixel) =>
            {
                g.FillRectangle(brush, pixel.x, pixel.y, WIDTH, HEIGHT);
            });

            this.walls.ForEach((wall) =>
            {
                g.FillRectangle(brush_wall, wall.x, wall.y, WIDTH, HEIGHT);
            });

            this.foods.ForEach((food) =>
            {
                g.FillRectangle(brush_food, food.x, food.y, WIDTH, HEIGHT);
            });
        }


        private void startGame()
        {
            this.gameOver = false;

            this.foods.Clear();
            this.walls.Clear();
            this.gameOverPanel.Hide();

            this.snake = new Snake();

            this.score = 0;
            labelScore.Text = this.score.ToString();

            addElements("food", NB_FOODS_INIT);
            addElements("wall", NB_WALLS_INIT);
        }


        private void addElements(string type, int nb)
        {
            Random rnd = new Random();

            for (int i = 0; i < nb; i++)
            {
                int random_x = (rnd.Next(0, (gamePanel.Width / 20) - 1)) * 20;
                int random_y = (rnd.Next(0, (gamePanel.Height / 20) - 1)) * 20;

                if (checkEmptyPosition(random_x, random_y))
                {
                    if (type == "food") this.foods.Add(new Food(random_x, random_y));
                    else this.walls.Add(new Wall(random_x, random_y));
                }
                else i--;
            }
        }

        private bool checkEmptyPosition(int x, int y)
        {
            for (int i = 0; i < this.foods.Count(); i++)
            {
                if (x == this.foods.ElementAt(i).x && y == this.foods.ElementAt(i).y)
                {
                    return false;
                }
            }

            for (int i = 0; i < this.walls.Count(); i++)
            {
                if (x == this.walls.ElementAt(i).x && y == this.walls.ElementAt(i).y)
                {
                    return false;
                }
            }

            for (int i = 0; i < this.snake.pixels.Count(); i++)
            {
                if (x == this.snake.pixels.ElementAt(i).x && y == this.snake.pixels.ElementAt(i).y)
                {
                    return false;
                }
            }

            return true;
        }


        private void checkBorders()
        {
            Pixel head = this.snake.pixels.ElementAt(0);

            if (head.x > (gamePanel.Width - 19))
            {
                head.x = 0;
            }
            if (head.x < 0)
            {
                head.x = gamePanel.Width;
            }
            if (head.y > (gamePanel.Height - 19))
            {
                head.y = 0;
            }
            if (head.y < 0)
            {
                head.y = gamePanel.Height;
            }

        }

        private void checkEat()
        {
            Pixel head = this.snake.pixels.ElementAt(0);

            for (int i = 0; i < this.foods.Count(); i++)
            {
                Food f = this.foods.ElementAt(i);

                if (head.x == f.x && head.y == f.y)
                {
                    int last_pixel_x, last_pixel_y;

                    last_pixel_x = this.snake.pixels.ElementAt(this.snake.pixels.Count - 1).x;
                    last_pixel_y = this.snake.pixels.ElementAt(this.snake.pixels.Count - 1).y;

                    this.score += 20;
                    labelScore.Text = this.score.ToString();

                    this.snake.pixels.Add(new Pixel(last_pixel_x, last_pixel_y));

                    this.foods.RemoveAt(i);
                    addElements("food", 1);
                }
            }
        }

        private void checkWall()
        {
            Pixel head = this.snake.pixels.ElementAt(0);

            foreach (Wall w in walls)
            {
                if (head.x == w.x && head.y == w.y)
                {
                    this.gameOver = true;
                }

            }
        }

        private void checkItself()
        {
            for (int i = 2; i < this.snake.pixels.Count(); i++)
            {
                if (this.snake.pixels.ElementAt(0).x == this.snake.pixels.ElementAt(i).x && this.snake.pixels.ElementAt(0).y == this.snake.pixels.ElementAt(i).y)
                {
                    this.gameOver = true;
                }

            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                    if (this.snake.direction.x != -1)
                    {
                        this.snake.direction.x = 1;
                        this.snake.direction.y = 0;
                    }
                    return true;
                case Keys.Left:
                    if (this.snake.direction.x != 1)
                    {
                        this.snake.direction.x = -1;
                        this.snake.direction.y = 0;
                    }
                    return true;
                case Keys.Up:
                    if (this.snake.direction.y != 1)
                    {
                        this.snake.direction.y = -1;
                        this.snake.direction.x = 0;
                    }
                    return true;
                case Keys.Down:

                    if (this.snake.direction.y != -1)
                    {
                        this.snake.direction.y = 1;
                        this.snake.direction.x = 0;

                    }
                    return true;
                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }


        private void labelRestart_Click(object sender, EventArgs e)
        {
            startGame();

        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void reduceLabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            // pause du jeu
        }

        private void boxPseudo_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(boxPseudo.Text))
            {
                labelSave.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            }
            else
            {
                labelSave.ForeColor = System.Drawing.ColorTranslator.FromHtml("#777777");
            }
        }

        private void labelSave_Click(object sender, EventArgs e)
        {

            string userName = boxPseudo.Text;
            int userScore = Int32.Parse(labelEndScore.Text);

            Score.LoadData(SCORES_FILENAME);
            Score.RegisterScore(userName, userScore);
            Score.SaveData(SCORES_FILENAME);

            boxPseudo.Hide();
            labelSave.Hide();
            labelSaveName.Hide();

            labelSaveOk.Show();
        }

        private void scoresTab_Click(object sender, EventArgs e)
        {

            ScoreTab st = new ScoreTab();
            st.TopLevel = false;
            st.AutoScroll = true;
            resetTabs();
            contentPanel.Controls.Add(st);
            st.Show();
        }


        private void resetTabs()
        {
            gamePanel.Paint += null;
            gameTimer.Tick += null;
            gameTimer.Stop();

            this.snake = null;

            label1.Hide();
            labelScore.Hide();
            label4.Hide();

            contentPanel.Controls.Clear();
           
        }

        private void labelPlay_Click(object sender, EventArgs e)
        {  
            resetTabs();
            contentPanel.Controls.Add(gamePanel);

            label1.Show();
            labelScore.Show();
            label4.Show();

            gamePanel.Paint += new PaintEventHandler(gamePanel_Paint);

            gameTimer.Interval = 100;
            gameTimer.Tick += draw;
            gameTimer.Start();

            this.snake = new Snake();
            startGame(); 
        }

        private void labelGroupe_Click(object sender, EventArgs e)
        {
            GroupeTab st = new GroupeTab();
            st.TopLevel = false;
            st.AutoScroll = true;
            resetTabs();
            contentPanel.Controls.Add(st);
            st.Show();
        }
    }
}
