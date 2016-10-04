namespace Shapes
{
    using Models;
    using System;

    public class ShapesRunTest
    {
        public static void Run()
        {
            Console.WriteLine("Calculating surfaces of different figures.");
            Console.WriteLine(new string('*', 40));
            Shape[] shapes = new Shape[]
            {
                new Triangle(10.5, 14.7),
                new Rectangle(14.5, 6.7),
                new Circle(4.4, 7.2)
            };

            foreach (Shape figure in shapes)
            {
                Console.WriteLine("{0} = {1}", figure.GetType().Name, figure.CalculateSurface());
            }
            Console.WriteLine(new string('*', 40));
        }
    }
}
