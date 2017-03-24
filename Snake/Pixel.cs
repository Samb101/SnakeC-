
using System;
using System.Drawing;
namespace SnakeProject
{
    class Pixel
    {
        internal int x { get; set; }
        internal int y { get; set; }
        public Vector direction;
        public bool isRotating;


        public Pixel(int x, int y, Vector direction){
            this.x = x;
            this.y = y;
            this.direction = direction;
            this.isRotating = false;
        }

        public RotateFlipType computeRotation() {


            if (this.direction.x == 0 && this.direction.y == 1)
            {
                return RotateFlipType.Rotate90FlipNone;

            }
            if (this.direction.x == 1 && this.direction.y == 0)
            {
                return RotateFlipType.RotateNoneFlipNone;

            }
            if (this.direction.x == 0 && this.direction.y == -1)
            {
                return RotateFlipType.Rotate270FlipNone;

            }
            if (this.direction.x == -1 && this.direction.y == 0)
            {
                return RotateFlipType.Rotate180FlipNone;

            }







            if (this.direction.x == 1 && this.direction.y == 1)
            {
                return RotateFlipType.RotateNoneFlipNone;

            }
            if (this.direction.x == -1 && this.direction.y == 1)
            {
                return RotateFlipType.RotateNoneFlipY;

            }
            if (this.direction.x == 1 && this.direction.y == -1)
            {
                return RotateFlipType.RotateNoneFlipNone;
            }
            if (this.direction.x == -1 && this.direction.y == -1)
            {
                return RotateFlipType.RotateNoneFlipY;
            }

            return RotateFlipType.Rotate270FlipY;

        }
    }
}