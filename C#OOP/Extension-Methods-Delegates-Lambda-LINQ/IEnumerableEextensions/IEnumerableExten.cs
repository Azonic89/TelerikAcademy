namespace IEnumerableExtensions
{
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExten
    {
       
        public static T MySum<T>(this IEnumerable<T> array)
        {
            dynamic sum = 0;

            foreach (var item in array)
            {
                sum += item;
            }

            return sum;
        }

        public static T MyProduct<T>(this IEnumerable<T> array)
        {
            dynamic product = 1;

            foreach (var item in array)
            {
                product *= item;
            }

            return product;
        }

        public static T MyMin<T>(this IEnumerable<T> array)
        {
            dynamic min = array.First();

            foreach (var item in array)
            {
                if (min > item)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T MyMax<T>(this IEnumerable<T> array)
        {
            dynamic max = array.First();

            foreach (var item in array)
            {
                if (max < item)
                {
                    max = item;
                }
            }

            return max;
        }

        public static double MyAverage<T>(this IEnumerable<T> array)
        {
            T sum = array.MySum();

            return (dynamic)sum / (double)array.Count();
        }
    }
}
