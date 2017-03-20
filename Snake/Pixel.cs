
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

        public RotateFlipType computeRotationX()
        {
            switch (this.direction.x)
            {
                case -1:
                    return RotateFlipType.Rotate180FlipY;
                case 1:
                    return RotateFlipType.RotateNoneFlipY;
                default:
                    return RotateFlipType.RotateNoneFlipY;
            }
        }


        public RotateFlipType computeRotationY()
        {
            switch (this.direction.y)
            {
                case 1:
                    return RotateFlipType.Rotate270FlipY;
                case -1:
                    return RotateFlipType.Rotate90FlipY;
                default:
                    return RotateFlipType.RotateNoneFlipY;
            }
        }

        public RotateFlipType computeRotation() {
            return this.computeRotationX() == RotateFlipType.RotateNoneFlipY
                    ? this.computeRotationY()
                    : this.computeRotationX();
        }
    }
}