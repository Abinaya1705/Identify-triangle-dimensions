using NUnit.Framework;
using Identify_triangle_dimensions;

namespace Test_triangle
{
    public class Tests_triangle
    {
        public object TriangleType { get; private set; }
        public object TriangleTester { get; private set; }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_GetTriangleType()
        {
            Assert.AreEqual(TriangleType.Equilateral,
                            TriangleTester.GetTriangleType(4, 4, 4),
                            "GetTriangleType(4, 4, 4) did not return Equilateral");

            Assert.AreEqual(TriangleType.Isosceles,
                            TriangleTester.GetTriangleType(4, 4, 3),
                            "GetTriangleType(4, 4, 3) did not return Isosceles");

            Assert.AreEqual(TriangleType.Scalene,
                            TriangleTester.GetTriangleType(4, 3, 2),
                            "GetTriangleType(4, 3, 2) did not return Scalene");

            Assert.AreEqual(TriangleType.Error,
                            TriangleTester.GetTriangleType(-4, 4, 4),
                            "GetTriangleType(-4, 4, 4) did not return Error");

            Assert.AreEqual(TriangleType.Error,
                            TriangleTester.GetTriangleType(@, #, $),
                            "GetTriangleType(@, #, $) did not return Error");

            Assert.AreEqual(TriangleType.Error,
                            TriangleTester.GetTriangleType(, 5, -4),
                            "GetTriangleType(4, 4, -4) did not return Error");
        }
    }

}


        
    
