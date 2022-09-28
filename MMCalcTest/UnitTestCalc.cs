using MMCalc.Repos;

namespace MMCalcTest
{
    [TestClass]
    public class TestCalc
    {
        [TestMethod]
        public void TestCalcAdd()
        {

            Calc calc = new Calc();

            float result = calc.Add(2, 2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestCalcSubtract()
        {

            Calc calc = new Calc();

            float result = calc.Subtract(10, 5);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestCalcMultiply()
        {

            Calc calc = new Calc();

            float result = calc.Multiply(2, 2);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestCalcDivide()
        {

            Calc calc = new Calc();

            float result = calc.Divide(10, 2);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestCalcDivideZero()
        {

            Calc calc = new Calc();

            float result = calc.Divide(10, 0);

            Assert.AreEqual(0, 0);
        }
    }
}