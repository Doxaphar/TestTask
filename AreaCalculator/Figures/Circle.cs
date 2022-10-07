using System;

namespace AreaCalculator
{
    public class Circle : IFigure
    {
        protected readonly double Radius;
        
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Circle does not exist");
            }
            this.Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}