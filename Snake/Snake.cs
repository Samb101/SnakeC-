using System;
using System.Collections.Generic;
using System.Linq;


namespace SnakeProject
{
    class Snake
    {
        public List<Pixel> pixels;
        public int life { get; set; }


        public Snake()
        {

            this.life = 3;
            this.pixels = new List<Pixel>();

            this.pixels.Add(new Pixel(0, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-20, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-40, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-60, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-80, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-100, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-120, 0, new Vector(1, 0)));
        }


        public void nextStep(int gameSpeed){

            if (this.pixels.ElementAt(0).direction.y != this.pixels.ElementAt(1).direction.y || this.pixels.ElementAt(0).direction.x != this.pixels.ElementAt(1).direction.x)
            {
                Console.WriteLine("coudee");
                this.pixels.ElementAt(0).isRotating = true;
            }


            for (int i = this.pixels.Count() - 1; i > 0; i--)
            {

                this.pixels.ElementAt(i).x = this.pixels.ElementAt(i - 1).x;
                this.pixels.ElementAt(i).y = this.pixels.ElementAt(i - 1).y;

                if (this.pixels.ElementAt(i).direction.x != this.pixels.ElementAt(i - 1).direction.x || this.pixels.ElementAt(i).direction.y != this.pixels.ElementAt(i - 1).direction.y)
                {
                    this.pixels.ElementAt(i).isRotating = true;
                }
                this.pixels.ElementAt(i).direction = this.pixels.ElementAt(i - 1).direction;
            }

            this.pixels.ElementAt(0).x += this.pixels.ElementAt(0).direction.x * gameSpeed;
            this.pixels.ElementAt(0).y += this.pixels.ElementAt(0).direction.y * gameSpeed;
        }
    }
}
