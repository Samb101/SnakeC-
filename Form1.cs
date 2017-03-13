using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;



namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        private int SPEED = 20;
        private Snake snake;

        public Form1()
        {
            InitializeComponent();

            this.snake = new Snake();

            gamePanel.Paint += new PaintEventHandler(draw);
            gamePanel.Refresh();

            gameTimer.Interval = 100;
           // gameTimer.Tick += draw;
            gameTimer.Start(); 

        }

        public void draw(object sender, PaintEventArgs e)
        {
            SolidBrush blackpen = new SolidBrush(Color.Black);
            Graphics gs = e.Graphics;

            int width = 20;
            int height = 20;

            gs.Clear(Color.Beige);

            this.snake.pixels.ForEach((pixel) =>
            {
               gs.FillRectangle(blackpen, pixel.x, pixel.y, width, height);
            });

            this.snake.nextStep(this.SPEED);

        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Right:
                case Keys.Left:
                case Keys.Up:
                case Keys.Down:

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

    }
}
