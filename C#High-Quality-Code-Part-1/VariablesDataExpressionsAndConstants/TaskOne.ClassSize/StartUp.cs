namespace TaskOne.ClassSize
{
    using System;

    using Models;

    public class StartUp
    {
        private const double InitialSizeWidth = 33.4;
        private const double InitialSizeHeight = 25.6;
        private const double RotationAngle = 30;

        public static void Main()
        {
            var initial = new Rectangle(InitialSizeWidth, InitialSizeHeight);
            Console.WriteLine(initial);

            var rotatedSize = Rectangle.RotatedSize(initial, RotationAngle);
            Console.WriteLine(rotatedSize);
        }
    }
}
