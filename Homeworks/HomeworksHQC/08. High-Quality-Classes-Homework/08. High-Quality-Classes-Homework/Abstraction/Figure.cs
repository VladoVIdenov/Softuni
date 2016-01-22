namespace Abstraction
{
    using System;

    public abstract class Figure : IFigure
    {
        private double width;

        private double height;

        private double radius;

        public Figure()
        {
        }

        protected Figure(double radius)
        {
            this.Radius = radius;
        }

        protected Figure(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public virtual double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The Width cannot be negative or zero");
                }

                this.width = value;
            }
        }

        public virtual double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The Height cannot be negative or zero");
                }

                this.height = value;
            }
        }

        public virtual double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The Radius cannot be negative or zero");
                }

                this.radius = value;
            }
        }

        public abstract double CalcSurface();

        public abstract double CalcPerimeter();
    }
}
