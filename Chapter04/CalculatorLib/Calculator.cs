namespace CalculatorLib
{
    public class Calculator
    {
        public double Add(double a , double b)
        {
            if((a == double.MaxValue&&b>=0) || (b == double.MaxValue&&a>=0))
            {
                //throw new OverflowException(message: $"{nameof(a)} = {a}, {nameof(b)} = {b} and sum cannot be more than max value of double {double.MaxValue}");
                return double.MaxValue;
            }
            return a + b;
        }
    }
}