using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Figures.Test
{
    [TestClass]
    public class CicleTest
    {
        [TestMethod]
        public void CircleCount_Check()
        {
            var actual = new Lib.Circle(1).Square;
            double expected = 3.14;

            Assert.AreEqual(expected, actual, $"Actual {actual}, expected {expected}. Not equal");
        }
    }
}
