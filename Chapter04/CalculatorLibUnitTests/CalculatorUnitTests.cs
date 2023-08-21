using CalculatorLib;
namespace CalculatorLibUnitTests
{
    public class CalculatorUnitTests
    {
        [Fact]
        public void TestAdding2And2()
        {
            // arrange
            double a = 2;
            double b = 2;
            double expected = 4;
            Calculator calc = new Calculator();
            // act
            double actual = calc.Add(a, b);
            // assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAdding2And3()
        {
            double a = 2;
            double b = 3;
            double expected = 5;
            Calculator calc = new Calculator();
            double actual = calc.Add(a,b);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void TestAdding1AndMax()
        {
            double a = 1;
            double b = double.MaxValue;
            double expected = double.MaxValue;
            Calculator calc = new Calculator();
            double actual = calc.Add(a, b);
            Assert.Equal(expected, actual);
        }
    }
}