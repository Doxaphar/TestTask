using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaCalculator.Figures
{
    public class Triangle : IFigure
    {
        protected readonly double _a, _b, _c;
        public enum Type
        {
            Acute,
            Right,
            Obtuse
        }
        
        public Triangle(double a, double b, double c)
        {
            var maxSide = Math.Max(a, Math.Max(b, c));
            if (maxSide >= a + b + c - maxSide || a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Triangle does not exist");
            }
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public double GetArea()
        {
            var p = (_a + _b + _c) / 2;
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        public new Type GetType()
        {
            var sides = new List<double> { _a, _b, _c }
                .Select(x => Math.Pow(x, 2))
                .OrderBy(x => x)
                .ToList();
            if (sides[1] + sides[0] > sides[2])
            {
                return Type.Acute;
            }

            if (Math.Abs(sides[1] + sides[0] - sides[2]) < Double.Epsilon)
            {
                return Type.Right;
            }

            return Type.Obtuse;
        }
    }
}