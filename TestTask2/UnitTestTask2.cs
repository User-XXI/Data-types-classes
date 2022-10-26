using System.Drawing;

namespace UnitTestTask2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPerimeterCalculator()
        {
            double tsideA = 5;
            double tsideB = 10;

            Rectangle testRectangle = new Rectangle(tsideA,tsideB);
            double actualPerimeter = (tsideA + tsideB) * 2;
            Assert.AreEqual( testRectangle.Perimeter, actualPerimeter );
        }

        [TestMethod]
        public void TestAreaCalculator()
        {
            double tsideA = 5;
            double tsideB = 10;

            Rectangle testRectangle = new Rectangle(tsideA,tsideB);
            double actualArea = (tsideA * tsideB);
            Assert.AreEqual( testRectangle.Area, actualArea );
        }

        [TestMethod]
        public void TestOneNegativуSide()
        {
            double tsideA = -5;
            double tsideB = 10;

            Rectangle testRectangle = new Rectangle(tsideA, tsideB);
            Assert.AreEqual( testRectangle.Perimeter, 0 );
            Assert.AreEqual( testRectangle.Area, -1 );
        }

        [TestMethod]
        public void TestTwoNegativуSide()
        {
            double tsideA = -5;
            double tsideB = -10;

            Rectangle testRectangle = new Rectangle(tsideA, tsideB);
            Assert.AreEqual( testRectangle.Perimeter, 0 );
            Assert.AreEqual( testRectangle.Area, -1 );
        }

        [TestMethod]
        public void TestOneZeroSide()
        {
            double tsideA = 0;
            double tsideB = 10;

            Rectangle testRectangle = new Rectangle(tsideA, tsideB);
            Assert.AreEqual( testRectangle.Perimeter, 0 );
            Assert.AreEqual( testRectangle.Area, -1 );
        }

        [TestMethod]
        public void TestTwoZeroSide()
        {
            double tsideA = 0;
            double tsideB = 0;

            Rectangle testRectangle = new Rectangle(tsideA, tsideB);
            Assert.AreEqual( testRectangle.Perimeter, 0 );
            Assert.AreEqual( testRectangle.Area, -1 );
        }
    }
}
