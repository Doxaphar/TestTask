using AreaCalculator.Figures;

namespace AreaCalculator
{
    public class AreaCalculator
    {
        public Triangle GetTriangle(double a, double b, double c)
        {
            return new Triangle(a, b, c);
        }
        
        public Circle GetCircle(double radius)
        {
            return new Circle(radius);
        }
        
        public double GetArea(IFigure figure)
        {
            return figure.GetArea();
        }

        public double GetTriangleArea(double a, double b, double c)
        {
            return GetArea(GetTriangle(a, b, c));
        }
        
        public double GetCircleArea(double radius)
        {
            return GetArea(GetCircle(radius));
        }
        
        public Triangle.Type GetTriangleType(Triangle triangle)
        {
            return triangle.GetType();
        }
        
        public Triangle.Type GetTriangleType(double a, double b, double c)
        {
            return GetTriangle(a, b, c).GetType();
        }
    }
}