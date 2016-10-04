namespace Shapes.Models
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height)
            : base(width, height)
        {

        }

        public override double CalculateSurface()
        {
            double surface = (Width * Height) / 2;
            return surface;
        }
    }
}
