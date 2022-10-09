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
        
        public double GetArea(double a, double b, double c)
        {
            return GetTriangle(a, b, c).GetArea();
        }
        
        public double GetArea(double radius)
        {
            return GetCircle(radius).GetArea();
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