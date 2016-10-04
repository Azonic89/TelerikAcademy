using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods.Utils
{
    internal class CalculationHelpers
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            var isValidTriangle = CheckIfSideLengthCanComposeAValidTriangle(a, b, c);
            if (!isValidTriangle)
            {
                throw new ArgumentException("Sides are of invalid length.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double areaSqr = halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c);
            double area = Math.Sqrt(areaSqr);
            return area;
        }

        public static string DigitToWord(int number)
        {
            var digitTranslations = new Dictionary<int, string>()
            {
                { 0, "zero" },
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
            };

            string result;
            if (digitTranslations.ContainsKey(number))
            {
                result = digitTranslations[number];
            }
            else
            {
                throw new ArgumentException("Number is not a digit.");
            }

            return result;
        }

        public static int FindMaximumValue(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentException("No elements to evaluate.");
            }

            var maximumValue = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (maximumValue < elements[i])
                {
                    maximumValue = elements[i];
                }
            }

            return maximumValue;
        }

        public static double CalculateDistance(
            double pointOneCoordinateX,
            double pointOneCoordinateY,
            double pointTwoCoordinateX,
            double pointTwoCoordinateY,
            out bool isHorizontal,
            out bool isVertical)
        {
            isHorizontal = (pointOneCoordinateY == pointTwoCoordinateY);
            isVertical = (pointOneCoordinateX == pointTwoCoordinateX);

            var distanceX = pointTwoCoordinateX - pointOneCoordinateX;
            var distanceY = pointTwoCoordinateY - pointOneCoordinateY;

            double distance = Math.Sqrt((distanceX * distanceX) + (distanceY * distanceY));
            return distance;
        }

        private static bool CheckIfSideLengthCanComposeAValidTriangle(double sideA, double sideB, double sideC)
        {
            var isSideAValid = sideA < (sideB + sideC);
            var isSideBValid = sideB < (sideA + sideC);
            var isSideCValid = sideC < (sideA + sideB);
            var isValidTriangle = isSideAValid && isSideBValid && isSideCValid;

            return isValidTriangle;
        }
    }
}
