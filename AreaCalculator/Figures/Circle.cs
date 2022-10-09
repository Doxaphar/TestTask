using System;

namespace AreaCalculator
{
    public class Circle : IFigure
    {
        protected readonly double _radius;
        
        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Circle does not exist");
            }
            this._radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * _radius * _radius;
        }
    }
}