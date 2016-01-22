using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01Point3D
{
    public class Path3D
    {
        private List<Point3D> Path;
        
        public Path3D(params Point3D[] points)
        {
            this.Path = new List<Point3D>();
            this.AddPoints(points);
        }

        public IEnumerable<Point3D> Points
        {
            get
            {
                return this.Path;
            }
        }

        public void AddPoints(params Point3D[] points)
        {
            foreach (var point in points)
            {
                this.Path.Add(point);
            }
        }
    }
}
