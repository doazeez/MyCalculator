using System;

namespace ClassLibrary1
{
    public class TrigonometryOperations
    {
        /// <summary>
        /// The following methods perform  sine, Cosine and Tangent operation
        /// </summary>
        /// <param name="num1"></param>
        /// <returns>Returns Answer in degree</returns>
        public double Sine(double num1)
        {
            double result = (num1 * (Math.PI)) / 180;
            return Math.Sin(result);
        }
        public double Cosine(double num1)
        {
            double result = (num1 * (Math.PI)) / 180;
            return Math.Cos(result);
        }
        public double Tangent(double num1)
        {
            double result = (num1 * (Math.PI)) / 180;
            return Math.Tan(result);
        }
        /// <summary>
        /// the following methods perform sine, Cosine and Tangent operation
        /// </summary>
        /// <param name="num1"></param>
        /// <returns> returns Answer in Radian</returns>
        public double SineInRadian(double num1)
        {
            double result = Math.Sin(num1);
            return result;
        }
        public double CosineInRadian(double num1)
        {
            double result = Math.Cos(num1);
            return result;
        }
        public double TangentInRadian(double num1)
        {
            double result = Math.Tan(num1);
            return result;
        }
        /// <summary>
        /// the following methods perform inverse function of sine, cosine and tangent
        /// </summary>
        /// <param name="num1"></param>
        /// <returns>returns answer in radian</returns>
        public double SineInverse(double num1)
        {
            double result = (num1);
            return Math.Asin(result);
        }
        public double CosineInverse(double num1)
        {
            double result = (num1);
            return Math.Acos(result);
        }
        public double TangentInverse(double num1)
        {
            double result = (num1);
            return Math.Atan(result);
        }
    }
}