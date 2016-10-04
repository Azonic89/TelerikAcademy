namespace EuclideanSpace.Models
{
    using System.Collections;
    using System.Collections.Generic;

    public class Path : IEnumerable<Point3D>
    {
        #region Fields
        private ICollection<Point3D> points;
        #endregion

        #region Methods
        public Path()
        {
            this.points = new List<Point3D>();
        }

        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.points.Remove(point);
        }

        public IEnumerator<Point3D> GetEnumerator()
        {
            return this.points.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
    }
}
