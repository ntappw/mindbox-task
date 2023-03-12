using ShapesLib.Domain;

namespace UnitTest.Shapes
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void ConstructorTestPositiveNumbers()
        {
            Assert.IsNotNull(Triangle.Create(8, 4, 7));
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ConstructorTestNegativeNumber()
        {
            Triangle.Create(8, -4, 7);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConstructorTestIncorrectNumbers()
        {
            Triangle.Create(2, 9, 15);
        }


        [TestMethod]
        public void AreaTest()
        {
            Assert.AreEqual(Triangle.Create(8,4,7).Area(), Math.Sqrt(3135) / 4);
        }


        [TestMethod]
        public void PerimeterTest()
        {
            Assert.AreEqual(Triangle.Create(8,4,7).Perimeter(), 19);
        }
    }
}