using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeProject
{
    public partial class SnakeGame : Form
    {
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
        
        public SnakeGame()
        {
            InitializeComponent();

            gamePanel.Paint += new PaintEventHandler(gamePanel_Paint);

            gameTimer.Interval = 100;
            gameTimer.Tick += draw;
            gameTimer.Start();

            this.snake = new Snake();
            startGame();
        }

        public void draw(object sender, EventArgs e)
        {
            if (this.gameOver == false)
            {
                this.snake.nextStep(this.SPEED);
                this.gamePanel.Invalidate();

                checkBorders();
                checkEat();
                checkWall();
                checkItself();

            }
            else
            {
                this.labelGameOver.Show();
                this.buttonRestart.Show();
            }
        }


        private void startGame()
        {
            this.gameOver = false;
            this.foods.Clear();
            this.walls.Clear();
            this.snake = new Snake();
            this.score = 0;
            labelScore.Text = this.score.ToString();

            buttonRestart.Hide();
            labelGameOver.Hide();

            addFoods(NB_FOODS_INIT);
            addWalls(NB_WALLS_INIT);
        }


        private void addFoods(int nb)
        {
            Random rnd = new Random();

            for (int i = 0; i < nb; i++)
            {
                int random_x = rnd.Next(1, 679) % 20 * 20;
                int random_y = rnd.Next(1, 379) % 20 * 20;

                if (checkEmptyPosition(random_x, random_y))
                {
                    this.foods.Add(new Food(random_x, random_y));
                }
                else i--;
             }
        }

        private void addWalls(int nb)
        {
            Random rnd = new Random();

            for (int i = 0; i < nb; i++)
            {
                int random_x = rnd.Next(1, 679) % 20 * 20;
                int random_y = rnd.Next(1, 379) % 20 * 20;

                if (checkEmptyPosition(random_x, random_y))
                {
                    this.walls.Add(new Wall(random_x, random_y));
                }
                else i--;
            }
        }


        private bool checkEmptyPosition(int x, int y)
        {
            for(int i = 0; i < this.foods.Count(); i++)
            {
                if ( x == this.foods.ElementAt(i).x  && y == this.foods.ElementAt(i).y)
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



        private void checkBorders()
        {
            Pixel head = this.snake.pixels.ElementAt(0);

            if (head.x > 681)
            {
                head.x = 0;
            }
            if (head.x < 0)
            {
                head.x = 700;
            }
            if (head.y > 381)
            {
                head.y = 0;
            }
            if (head.y < 0)
            {
                head.y = 400;
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
                    addFoods(1);
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
            for(int i = 2; i < this.snake.pixels.Count(); i++)
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

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            startGame();
        }
    }
}
