using System;
using System.Collections.Generic;
using System.Linq;


namespace SnakeProject
{
    class Snake
    {
        public List<Pixel> pixels;
        public int life { get; set; }
        private List<Vector> nodes = new List<Vector>();


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
            this.pixels.Add(new Pixel(-140, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-160, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-180, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-200, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-220, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-240, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-260, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-280, 0, new Vector(1, 0)));
            this.pixels.Add(new Pixel(-300, 0, new Vector(1, 0)));



        }


        public void nextStep(int gameSpeed)
        {

            // les anciens pixels prennent la place des précédents
            for (int i = this.pixels.Count() - 1; i > 0; i--)
            {
                this.pixels.ElementAt(i).x = this.pixels.ElementAt(i - 1).x;
                this.pixels.ElementAt(i).y = this.pixels.ElementAt(i - 1).y;
            }


            // on avance la tête
            this.pixels.ElementAt(0).x += this.pixels.ElementAt(0).direction.x * gameSpeed;
            this.pixels.ElementAt(0).y += this.pixels.ElementAt(0).direction.y * gameSpeed;

            // tri
            for (int i = 1; i < this.pixels.Count() - 1; i++)
            {

                this.pixels.ElementAt(i).direction.x = (this.pixels.ElementAt(i - 1).x - this.pixels.ElementAt(i + 1).x) / 40;
                this.pixels.ElementAt(i).direction.y = (this.pixels.ElementAt(i - 1).y - this.pixels.ElementAt(i + 1).y) / 40;
     
                
            }

            this.pixels.Last().direction.x = this.pixels.ElementAt(this.pixels.Count()-2).direction.x;
            this.pixels.Last().direction.y = this.pixels.ElementAt(this.pixels.Count()-2).direction.y;



        }
    }
}
