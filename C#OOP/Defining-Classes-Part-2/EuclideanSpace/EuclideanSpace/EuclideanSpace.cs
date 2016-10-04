namespace EuclideanSpace
{
    using System;
    using Models;
    using Extensions;

    class EuclideanSpace
    {
        static void Main()
        {
            Point3D point = new Point3D(1, 2, 3);

            Console.WriteLine(point);
            Console.WriteLine(Point3D.Origin);

            var distance = Point3DExtensions.CalculateDistance(point, Point3D.Origin);

            Console.WriteLine(distance);


            var path = new Path();
            for (int i = 0; i <= 20; i++)
            {
                path.AddPoint(new Point3D() { X = i, Y = i * 2, Z = i + 3 });
            }

            string pathStr = "../../path.txt";
            PathStorage.SavePath(path, pathStr);
            var pathFromFile = PathStorage.LoadPath(pathStr);

            foreach (var p in pathFromFile)
            {
                Console.WriteLine(p);
            }
        }
    }
}
