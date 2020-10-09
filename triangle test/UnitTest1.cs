using NUnit.Framework;
using Identify_triangle_dimensions;


namespace Test_triangle
{
    public class test_triangle
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

            public void Analyze_Input3and03and4_Output()
            {
                int a = 3;
                int b = 03;
                int c = 4;
                string expectedvalue = "Isosceles Triangle";
                string actualvalue = Triangle_solver.Analyze(a, b, c);

                Assert.AreEqual(expectedvalue, actualvalue);

            }
            [Test]

            public void Negative_value Inputnagative3andnegative4and4_Output()
            {
                int a = -3;
                int b = -4;
                int c = 4;
                string expextedvalue = 


            }

        }






        }
          

