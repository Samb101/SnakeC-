using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private int WIDTH = 20;
        private int HEIGHT = 20;
        private int SPEED = 20;
        private int NB_WALLS_FOODS = 5;


        private Snake snake;
        private List<Wall> walls = new List<Wall>();
        private List<Food> foods = new List<Food>();

        private int score;
        private bool gameOver;

        public Form1()
        {
            InitializeComponent();

            // PaintEvent => redessine a chaque modification d'élements
            gamePanel.Paint += new PaintEventHandler(gamePanel_Paint);

            this.snake = new Snake();
            this.score = 0;

            //gameTimer => check à chaque tick les modifications
            gameTimer.Interval = 100;
            gameTimer.Tick += draw;
            gameTimer.Start();

            generateWallsAndFoods();
        }


        private void generateWallsAndFoods()
        {
            Random rnd = new Random();
            for(int i=0; i < NB_WALLS_FOODS; i++)
            {

                //check

                if(1)
                this.walls.Add(new Wall(rnd.Next(1, 679)%20*20, rnd.Next(1, 379)%20*20));
                this.foods.Add(new Food(rnd.Next(1, 679)%20*20, rnd.Next(1, 379)%20*20));
            }
        }

        
        private void gamePanel_Paint(object sender, PaintEventArgs e)
        {
            //container graphics (jtavoue ça marche miraculeusement)
            var p = sender as Panel;
            //event graphics ma bite
            var g = e.Graphics;

            // le skin des pixels
            Brush brush = new SolidBrush(Color.DarkGreen);
            Brush brush_wall = new SolidBrush(Color.Blue);
            Brush brush_food = new SolidBrush(Color.IndianRed);

            //dessin école d'arts toussa
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

        public void draw(object sender, EventArgs e)
        {
            // Collisions

            // Bords
            Pixel head = this.snake.pixels.ElementAt(0);

            if(head.x > 699)
            {
                head.x = 0;
            }
            if (head.x < 0)
            {
                head.x = 699;
            }
            if (head.y > 399)
            {
                head.y = 0;
            }
            if (head.y < 0)
            {
                head.y = 399;
            }

            // Murs
            foreach(Wall w in walls)
            {
                if (head.x < w.x + WIDTH && head.x > w.x - WIDTH && head.y < w.y + HEIGHT && head.y > w.y - HEIGHT)
                {
                   //GameOver
                }

            }

            // Nourritures
           // int i = 0;

            for(int i = 0; i< this.foods.Count(); i++)
            {
                Food f = this.foods.ElementAt(i);

                if (head.x < f.x + WIDTH && head.x > f.x - WIDTH && head.y < f.y + HEIGHT && head.y > f.y - HEIGHT)
                {
                    int last_pixel_x, last_pixel_y;

                    last_pixel_x = this.snake.pixels.ElementAt(this.snake.pixels.Count - 1).x;
                    last_pixel_y = this.snake.pixels.ElementAt(this.snake.pixels.Count - 1).y;
                    
                    this.snake.pixels.Add(new Pixel(last_pixel_x, last_pixel_y));

                    this.foods.RemoveAt(i);    
                }
            }

            this.snake.nextStep(this.SPEED);
            gamePanel.Invalidate();

        }


        // donnée par l'énoncé, ça marche bien.
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
    
    }
}
