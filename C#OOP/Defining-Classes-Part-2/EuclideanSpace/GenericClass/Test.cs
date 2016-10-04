using System;
using GenericClass.Models;

namespace GenericClass
{
    public class Program
    {
        static void Main()
        {
            var list = new GenericList<int>(5);
            list.Add(10);
            list.Add(34);
            list.Add(27);

            list.Insert(1, 23);
            list.Insert(1, 443);
            list.Insert(1, 463);

            Console.WriteLine(list);

            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
        }
    }
}
