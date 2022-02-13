using System;

namespace ClassLibrary1
{
    public class ExponentialOperation
    {
        /// <summary>
        /// This method perform exponential of any power
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double Exponential(double num1, double num2)
        {
            double result = Math.Pow(num1, num2);
            return result;

        }
        /// <summary>
        /// this perform square operation
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public double Square(double num1, double num2)
        {
            double result = Math.Pow(num1, 2);
            return result;
        }
        public double Cube(double num1, double num2)
        {
            double result = Math.Pow(num1, 3);
            return result;
        }
        public double SquareRoot(double num1)
        {
            double result = Math.Sqrt(num1);
            return result;
        }
        public double CubeRoot(double num1)
        {
            double result = Math.Cbrt(num1);
            return result;
        }

    }
}
