using NUnit.Framework;
using Identify_triangle_dimensions;


namespace Test_triangle
{
    public partial class Test_triangle
    {
        [TestFixture]
        public class TestTriangle
        {
            [Test]

            public void Analyze_Input4and4and4_Output()
            {
                int a = 4;
                int b = 4;
                int c = 4;
                string expectedvalue = "Equilateral Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);

            }
            [Test]

            public void Analyze_Input3and3and4_Output()
            {
                int a = 3;
                int b = 3;
                int c = 4;
                string expectedvalue = "Isosceles Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);
            }
            [Test]

            public void Analyze_Input3and4and5_Output()
            {
                int a = 3;
                int b = 4;
                int c = 5;
                string expectedvalue = "scalene Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);

            }
            [Test]

            public void Analyze_Input3and3and4_Output()
            {
                int a = 3;
                int b = 3;
                int c = 4;
                string expectedvalue = "Isosceles Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);

            }
            [Test]

            public void Analyze_Input3and2and4_Output()
            {
                int a = 3;
                int b = -2;
                int c = 4;
                string expectedvalue = "Its not a Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);

            }
            [Test]

            public void Analyze_Input3and5and4_Output()
            {
                int a = 3;
                int b = -5;
                int c = -4;
                string expectedvalue = "Its not a Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);

            }
            [Test]

            public void Analyze_Input3and6and7_Output()
            {
                int a = -3;
                int b = -6;
                int c = 7;
                string expectedvalue = "Its not a Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);

            }
            [Test]

            public void Analyze_Input5and6and8_Output()
            {
                int a = -5;
                int b = -5;
                int c = -8;
                string expectedvalue = "Its not a Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);

            }
            [Test]

            public void Analyze_Input3and15and4_Output()
            {
                int a = 3;
                int b = 15;
                int c = 4;
                string expectedvalue = "Its not a Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);

            }
        }
    }
}


















