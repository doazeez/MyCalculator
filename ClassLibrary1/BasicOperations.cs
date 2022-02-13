using System;

namespace ClassLibrary1
{
    public class BasicOperations
    {
        /// <summary>
        /// The following methods perform addition, subtraction,multiplication,division and modulus
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns>return the answer of the operation </returns>
        public double Addition(double num1, double num2)
        {
            double result = num1 + num2;
            return result;

        }
        public double Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;

        }
        public double Multiply(double num1, double num2)
        {
            double result = num1 * num2;
            return result;

        }
        public double Division(double num1, double num2)
        {
            double result =0;
            if (num2 == 0) 
            {
                Console.WriteLine("undefine");
            }
            else
            {
               result =num1 / num2;
            }
            return result;
            


        }
        public double Modulus(double num1, double num2)
        {
            double result = num1 % num2;
            return result;

        }
    }
}
