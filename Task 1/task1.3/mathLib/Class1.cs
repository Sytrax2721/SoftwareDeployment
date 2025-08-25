using System;

namespace MathLib
{
    public static class MathService
    {
        public static decimal Add(decimal a, decimal b) => a + b;
        public static decimal Multiply(decimal a, decimal b) => a * b;
        public static decimal Subtract(decimal a, decimal b) => a - b;
        public static decimal Divide(decimal a, decimal b)
        {
            if (b == 0) throw new DivideByZeroException();
            return a / b;
        }
    }
}
