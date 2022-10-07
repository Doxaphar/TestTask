using System;
using System.Collections.Generic;
using System.Linq;

namespace AreaCalculator
{
    public class Triangle : IFigure
    {
        protected readonly double A, B, C;
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
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public double GetArea()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public Type GetType()
        {
            var sides = new List<double> { A, B, C }
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