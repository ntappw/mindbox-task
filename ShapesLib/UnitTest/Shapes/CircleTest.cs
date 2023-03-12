using ShapesLib.Domain;

namespace UnitTest.Shapes
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void ConstructorTestPositiveNumber()
        {
            Assert.IsNotNull(Circle.Create(10));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorTestNegativeNumber()
        {
            Circle.Create(-10);
        }


        [TestMethod]
        public void AreaTest()
        {
            Assert.AreEqual(Circle.Create(10).Area(), Math.PI * 100);
        }


        [TestMethod]
        public void PerimeterTest()
        {
            Assert.AreEqual(Circle.Create(10).Perimeter(), 2 * Math.PI * 10);
        }
    }
}