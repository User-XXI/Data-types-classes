namespace UnitTestTask1
{
    [TestClass]
    public class UnitTestTask1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                Assert.AreNotEqual( sw, "" );
            }
        }
    }
}