using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Figures.Test
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]    
        public void Triangle_Check()
        {
            var actual = new Lib.Triangle(3,4,5).Square;
            var expected = 6;

            Assert.AreEqual(expected, actual, $"Actual = {actual}, expected = {expected}");
        } 
        
        [TestMethod]    
        public void Triangle_IsRightAngled_Check()
        {
            var actual = new Lib.Triangle(3,4,5).IsRightAngled;
            var expected = true;

            Assert.AreEqual(expected, actual, $"Actual = {actual}, expected = {expected}");
        }
    }
}
