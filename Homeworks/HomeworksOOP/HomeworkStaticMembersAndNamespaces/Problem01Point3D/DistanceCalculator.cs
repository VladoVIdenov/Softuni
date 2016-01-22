using System;

namespace Problem01Point3D
{
    public static class DistanceCalculator
    {
        public static double CalculateDistance3D(Point3D firstPoint, Point3D secondPoint)
        {
            double result = 0;

            result = Math.Sqrt(
                (secondPoint.X - firstPoint.X) * (secondPoint.X - firstPoint.X) +
                (secondPoint.Y - firstPoint.Y) * (secondPoint.Y - firstPoint.Y) +
                (secondPoint.Z - firstPoint.Z) * (secondPoint.Z - firstPoint.Z));

            return result;
        }
    }
}
