using System.Collections.Generic;
using System.Text;

namespace Problem01Point3D
{
    public class Point3D
    {
        private static readonly Point3D startPoint;

        static Point3D()
        {
            startPoint = new Point3D(0, 0, 0);
        }
        public Point3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartPoint { get;  }
        public IEnumerable<Point3D> Points { get; internal set; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("X : {0}, Y : {1}, Y : {2}", this.X, this.Y, this.Z);
            return result.ToString();
        }
    }

}
