using System.Drawing;

namespace UnitTestTask3
{
    [TestClass]
    public class Task3Test
    {
        [TestMethod]
        public void Rectangle()
        {
            Figure fig1 = new Figure("Прямоугоьник",
                        new Point(1, 1), new Point(11, 1),
                        new Point(11, 6), new Point(1, 6));
            Assert.AreEqual( 30, fig1.getPerim(), "BadPram" );
        }

        [TestMethod]
        public void Triangle()
        {
            Figure fig2 = new Figure("Треугоьник",
                        new Point(1, 2), new Point(5, -1),
                        new Point(1, -1));
            Assert.AreEqual( 12, fig2.getPerim(), "BadTreug" );
        }

        [TestMethod]
        public void Square()
        {
            Figure fig3 = new Figure("Квадрат",
                        new Point(-1, -1), new Point(-1, 1),
                        new Point(1, 1), new Point(1, -1));
            Assert.AreEqual( 8, fig3.getPerim(), "BadKvad" );
        }

        [TestMethod]
        public void Pentagon()
        {
            Figure fig4 = new Figure("Пятиугоьник",
                        new Point(-3, -1), new Point(-3, 0),
                        new Point(0, 4), new Point(3, 0),
                        new Point(3, -1));
            Assert.AreEqual( 18, fig4.getPerim(), "BadPent" );
        }
    }
}