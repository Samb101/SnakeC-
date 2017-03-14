using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    class Snake
    {
        public List<Pixel> pixels;
        public int life { get; set; }
        public Vector direction;


        public Snake()
        {
            this.life = 3;
            this.pixels = new List<Pixel>();
            this.pixels.Add(new Pixel(0, 0));
            this.direction = new Vector(1, 0);
        }


        public void nextStep(int gameSpeed){

            for (int i = this.pixels.Count() - 1; i > 0; i--)
            {
                this.pixels.ElementAt(i).x = this.pixels.ElementAt(i - 1).x;
                this.pixels.ElementAt(i).y = this.pixels.ElementAt(i - 1).y;
            }

            this.pixels.ElementAt(0).x += this.direction.x * gameSpeed;
            this.pixels.ElementAt(0).y += this.direction.y * gameSpeed;
        }
    }
}
