namespace Shapes.Models
{
    using System;

    public class Circle : Shape
    {
        public Circle(double width, double height) 
            : base(width, height)
        {
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * (this.Width / 2.0) * (this.Height / 2.0);
            return surface;
        }
    }
}
