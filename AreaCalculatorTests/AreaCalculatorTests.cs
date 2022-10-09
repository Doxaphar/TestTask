using System;
using NUnit.Framework;
using AreaCalculator.Figures;

namespace AreaCalculatorTests
{
    [TestFixture]
    public class AreaCalculatorTests
    {
        private AreaCalculator.AreaCalculator _areaCalculator;
        [OneTimeSetUp]
        public void Setup()
        {
            _areaCalculator = new AreaCalculator.AreaCalculator();
        }
        
        [TestCase(6, 9, 13, TestName = "Basic triangle")]
        [TestCase(1, 1, 2, TestName = "Degenerated triangle")]
        public void GetTriangle_Success_Test(double a, double b, double c)
        {
            Assert.DoesNotThrow(() => _areaCalculator.GetTriangle(a, b, c), 
                "The triangle exists, but there are exceptions");
        }
        
        [TestCase(1, 1, 5, TestName = "Very big max side")]
        [TestCase(-1, -1, 0, TestName = "Negative side")]
        public void GetTriangle_DoesNotExist_Test(double a, double b, double c)
        {
            Assert.Throws<Exception>(() => _areaCalculator.GetTriangle(a, b, c), 
                "Triangle does not exist, but there are no exceptions");
        }
        
        [TestCase(3, TestName = "Basic circle")]
        [TestCase(0, TestName = "Degenerated circle")]
        public void GetCircle_Success_Test(double radius)
        {
            Assert.DoesNotThrow(() => _areaCalculator.GetCircle(radius), 
                "The circle exists, but there are exceptions");
        }
        
        [Test]
        public void GetCircle_DoesNotExist_Test()
        {
            Assert.Throws<Exception>(() => _areaCalculator.GetCircle(-1), 
                "Circle does not exist, but there are no exceptions");
        }
        
        [TestCase(3, 4, 5, 6, TestName = "Basic triangle")]
        [TestCase(0, 1, 1, 0, TestName = "Degenerated triangle")]
        public void GetTriangleArea_Success_Test(double a, double b, double c, double result)
        {
            Assert.AreEqual(result, Math.Round(_areaCalculator.GetArea(a, b, c), 5));
        }
        
        [TestCase(2, 12.56637, TestName = "Basic circle")]
        [TestCase(0, 0, TestName = "Degenerated circle")]
        public void GetCircleArea_Success_Test(double radius, double result)
        {
            Assert.AreEqual(result, Math.Round(_areaCalculator.GetArea(radius), 5));
        }
        
        [TestCase(3, 3, 5, Triangle.Type.Obtuse)]
        [TestCase(3, 4, 5, Triangle.Type.Right)]
        [TestCase(4, 4, 5, Triangle.Type.Acute)]
        public void GetTriangleTypeBySides_Success_Test(double a, double b, double c, Triangle.Type result)
        {
            Assert.AreEqual(result, _areaCalculator.GetTriangleType(a, b, c));
        }
    }
}