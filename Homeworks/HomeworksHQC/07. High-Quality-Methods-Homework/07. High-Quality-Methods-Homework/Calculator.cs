namespace Methods
{
    using System;

    public static class Calculator
    {
        /// <summary>
        /// Calulate Triangle area with Herons Formula
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Sides should be positive");
            }

            if (sideA >= sideB + sideC || sideB >= sideA + sideC || sideC >= sideA + sideB)
            {
                throw new ArgumentException("Sides", "The Triangle Inequality Theorem is not met");
            }

            double halfPerimeterLength = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(
                halfPerimeterLength *
                (halfPerimeterLength - sideA) *
                (halfPerimeterLength - sideB) *
                (halfPerimeterLength - sideC));
            return area;
        }

        /// <summary>
        /// Find a element with higest value.
        /// </summary>
        /// <param name="elements"></param>
        /// <returns></returns>
        public static double FindMax(params double[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Element", "The element cannot be null or zero");
            }

            double maxValue = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                maxValue = elements[0];
                if (elements[i] > elements[0])
                {
                    maxValue = elements[i];
                }
            }

            return maxValue;
        }

        /// <summary>
        /// Calculate distance between two points in coordinate system
        /// </summary>
        /// <param name="pointOneX">Cordinate X for the first Point</param>
        /// <param name="pointOneY">Cordinate Y for the first Point</param>
        /// <param name="pointTwoX">Cordinate X for the second Point</param>
        /// <param name="pointTwoY">Cordinate Y for the second Point</param>
        /// <param name="isHorizontal"></param>
        /// <param name="isVertical"></param>
        /// <returns></returns>
        public static double CalculateDistance(
            double pointOneX,
            double pointOneY,
            double pointTwoX,
            double pointTwoY)
        {
            if ((pointOneY == pointTwoY) && (pointOneX == pointTwoX))
            {
                throw new ArgumentException("There is no distance between points if they are at same coordinates");
            }

            double distance = Math.Sqrt(((pointTwoX - pointOneX) * (pointTwoX - pointOneX)) + ((pointTwoY - pointOneY) * (pointTwoY - pointOneY)));
            return distance;
        }

        public static bool CheckIsVertical(double pointOneX, double pointTwoX)
        {
            bool isVertical = false;
            if (pointOneX == pointTwoX)
            {
                isVertical = true;
            }

            return isVertical;
        }

        public static bool CheckIsHorizontal(double pointOneY, double pointTwoY)
        {
            bool isHorizontal = false;
            if (pointOneY == pointTwoY)
            {
                isHorizontal = true;
            }

            return isHorizontal;
        }
    }
}