namespace TaskOne.ClassSize.Models
{
    using System;

    using Contracts;

    public class Rectangle : ISize
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width Cannot be equal or less than zero!!!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height Cannot be equal or less than zero!!!");
                }

                this.height = value;
            }
        }

        public static Rectangle RotatedSize(ISize size, double rotationAngle)
        {
            var rotationAngleSinus = Math.Abs(Math.Sin(rotationAngle));
            var rotationAngleCosinus = Math.Abs(Math.Cos(rotationAngle));

            var widthAfterRotation = (rotationAngleCosinus * size.Width) + (rotationAngleSinus * size.Height);
            var heightAfterRotation = (rotationAngleSinus * size.Width) + (rotationAngleCosinus * size.Height);

            var newSize = new Rectangle(widthAfterRotation, heightAfterRotation);
            return newSize;
        }

        public override string ToString()
        {
            var width = this.Width.ToString("0.00");
            var height = this.Height.ToString("0.00");

            var toString = string.Format($"The size has width {width} and height {height} !");

            return toString;
        }
    }
}
