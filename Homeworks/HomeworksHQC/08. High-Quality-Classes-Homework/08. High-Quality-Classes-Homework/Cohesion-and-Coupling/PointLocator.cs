namespace CohesionAndCoupling
{
    using System;

    /// <summary>
    /// Calculate the points at which the objects are located in 2D or 3D Space.
    /// </summary>
    public static class PointLocator
    {
        /// <summary>
        /// Locate two points in 2D space by given cooridinates
        /// </summary>
        /// <param name="x1">First point X coordinates</param>
        /// <param name="y1">First point Y coordinates</param>
        /// <param name="x2">Second point X coordinates</param>
        /// <param name="y2">Second point Y coordinates</param>
        /// <returns></returns>
        public static double CalcDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        /// <summary>
        /// Locate two points in 3D space by given cooridinates
        /// </summary>
        /// <param name="x1">First point X coordinates</param>
        /// <param name="y1">First point Y coordinates</param>
        /// <param name="z1">First point Z coordinates</param>
        /// <param name="x2">Second point X coordinates</param>
        /// <param name="y2">Second point Y coordinates</param>
        /// <param name="z2">Second point Z coordinates</param>
        /// <returns></returns>
        public static double CalcDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)) + ((z2 - z1) * (z2 - z1)));
            return distance;
        }
    }
}
