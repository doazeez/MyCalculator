using System;

namespace ClassLibrary1
{
    public static class LogarithmFactorial
    {
        public static double Factorial(double num1)
        {
            double result = 1;
            for (int i = 1; i <= num1; i++)
            {
                result *= i;
            }
            return result;

        }
        public static double NaturalLogarithm(double num1)
        {
            double result = Math.Log(num1);
            return result;
        }
        public static double LogarithmToBaseTen(double num1)
        {
            double result = Math.Log10(num1);
            return result;
        }
    }
}
