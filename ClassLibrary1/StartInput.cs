using System;

namespace ClassLibrary1
{
    public static class StartInput
    {
        public static void Entry()
        {
           bool check = true;                        
            while (check)
            {
                double num1;
                double num2;
                string option;
                string operato;
                Console.WriteLine("\t\t\t\t\t\tSCIENTIFC CALCULATOR\n\n\n");
                Console.WriteLine("\t\t\t1. Basic Arithmetic\n\n");
                Console.WriteLine("\t\t\t2. Trigonometric, factorial and logarithm Function\n\n");
                Console.WriteLine("\t\t\t3. Exponential\n\n");

                Console.WriteLine("\t\t\t\r Input the number and press Enter to perform your operation \n");

                option = Console.ReadLine();
                switch (option)
                {

                    case "1":
                        Console.WriteLine("Enter value for First Number");
                        string numCheck = Console.ReadLine();
                        var validation = new Validation();

                        while (validation.NumberChecker(numCheck) == "Invalid input")
                        {
                            Console.WriteLine(validation.NumberChecker(numCheck));
                            Console.WriteLine("Re-enter your input");
                            numCheck = Console.ReadLine();
                        }
                        num1 = double.Parse(numCheck);
                        var basic = new BasicOperations();

                        Console.WriteLine("\t\t\tChoose the operator\n");
                        Console.WriteLine("\t\t\t+\t-\t*\t/\t%\n");                                              
                        operato = Console.ReadLine();
                        Console.WriteLine("Enter value for second Number");
                        string numCheck2 = Console.ReadLine();
                        while (validation.NumberChecker(numCheck2) == "Invalid input")
                        {
                            Console.WriteLine("Re-enter your input");
                            numCheck2 = Console.ReadLine();
                        }
                        num2 = Convert.ToDouble(numCheck2);
                        if (operato == "+")
                        {
                            double resultAdd = basic.Addition(num1, num2);
                            Console.WriteLine(resultAdd);
                        }
                        else if (operato == "-")
                        {
                            double resultSub = basic.Subtraction(num1, num2);
                            Console.WriteLine(resultSub);
                        }
                        else if (operato == "*")
                        {
                            double resultMul = basic.Multiply(num1, num2);
                            Console.WriteLine(resultMul);
                        }
                        else if (operato == "/")
                        {
                            double resultDiv = basic.Division(num1, num2);
                            Console.WriteLine(resultDiv);
                        }
                        else if (operato == "%")
                        {
                            double resultMod = basic.Modulus(num1, num2);
                            Console.WriteLine(resultMod);
                        }
                        else
                        {
                            Console.WriteLine("Wrong operator");
                        }

                        break;
                        
                    case "2":
                        var trigonometric = new TrigonometryOperations();
                        ; var exponential = new ExponentialOperation();
                        Console.WriteLine("Enter value for the function");
                        string numCheck3 = Console.ReadLine();
                        var validation1 = new Validation();

                        while (validation1.NumberChecker(numCheck3) == "Invalid input")
                        {
                            Console.WriteLine(validation1.NumberChecker(numCheck3));
                            Console.WriteLine("Re-enter your input");
                            numCheck3 = Console.ReadLine();
                        }
                        num1 = double.Parse(numCheck3);
                        Console.WriteLine("\t\t\tChoose the operator\n");
                        Console.WriteLine("\t\t\tsqr\tcube\tsqrt\tcbrt\t!\n");
                        Console.WriteLine("\t\t\tsin\tcos\ttan\tAsin\n");
                        Console.WriteLine("\t\t\tAcos\tAtan\tlog\tlog10\n");
                        Console.WriteLine("\t\t\tsinr\tcosr\ttanr\n");
                        operato = Console.ReadLine();
                        if (operato == "sqr")
                        {
                            double resultSq = exponential.Square(num1, 2);
                            Console.WriteLine(resultSq);
                        }
                        else if (operato == "cube")
                        {
                            double resultCu = exponential.Cube(num1, 3);
                            Console.WriteLine(resultCu);
                        }
                        else if (operato == "!")
                        {
                            double resultFac = LogarithmFactorial.Factorial(num1);
                            Console.WriteLine(resultFac);

                        }
                        else if (operato == "sin")
                        {
                            double resultSin = trigonometric.Sine(num1);
                            Console.WriteLine(resultSin);

                        }
                        else if (operato == "cos")
                        {
                            double resultCos = trigonometric.Cosine(num1);
                            Console.WriteLine(resultCos);

                        }
                        else if (operato == "tan")
                        {
                            double resultTan = trigonometric.Tangent(num1);
                            Console.WriteLine(resultTan);
                        }
                        else if (operato == "sinr")
                        {
                            double resultSr = trigonometric.SineInRadian(num1);
                            Console.WriteLine(resultSr);
                        }
                        else if (operato == "cosr")
                        {
                            double resultCr = trigonometric.CosineInRadian(num1);
                            Console.WriteLine(resultCr);
                        }
                        else if (operato == "tanr")
                        {
                            double resultTa = trigonometric.TangentInRadian(num1);
                            Console.WriteLine(resultTa);
                        }
                        else if (operato == "Asin")
                        {
                            double resultSi = trigonometric.SineInverse(num1);
                            Console.WriteLine(resultSi);
                        }
                        if (operato == "Acos")
                        {
                            double resultCo = trigonometric.CosineInverse(num1);
                            Console.WriteLine(resultCo);
                        }
                        else if (operato == "Atan")
                        {
                            double resultTan = trigonometric.TangentInverse(num1);
                            Console.WriteLine(resultTan);
                        }
                        else if (operato == "log")
                        {
                            double resultLog = LogarithmFactorial.NaturalLogarithm(num1);
                            Console.WriteLine(resultLog);
                        }
                        else if (operato == "log10")
                        {
                            double resultLog2 = LogarithmFactorial.LogarithmToBaseTen(num1);
                            Console.WriteLine(resultLog2);
                        }
                        else if (operato == "sqrt")
                        {
                            double resultSqt = exponential.SquareRoot(num1);
                            Console.WriteLine(resultSqt);
                        }
                        else if (operato == "cbrt")
                        {
                            double resultCrt = exponential.CubeRoot(num1);
                            Console.WriteLine(resultCrt);
                        }
                       
                        break;
                    case "3":
                        var exponentia = new ExponentialOperation();
                        Console.WriteLine("Enter value for base");
                        string numCheck4 = Console.ReadLine();
                        var validation2 = new Validation();

                        while (validation2.NumberChecker(numCheck4) == "Invalid input")
                        {
                            Console.WriteLine(validation2.NumberChecker(numCheck4));
                            Console.WriteLine("Re-enter your input");
                            numCheck4 = Console.ReadLine();
                        }
                        num1 = double.Parse(numCheck4);
                        Console.WriteLine("Enter value for power");
                        string numCheck5 = Console.ReadLine();
                        var validation3 = new Validation();

                        while (validation3.NumberChecker(numCheck5) == "Invalid input")
                        {
                            Console.WriteLine(validation3.NumberChecker(numCheck5));
                            Console.WriteLine("Re-enter your input");
                            numCheck5 = Console.ReadLine();
                        }
                        num2 = double.Parse(numCheck5);
                        double result = exponentia.Exponential(num1, num2);
                        Console.WriteLine(result);
                        break;

                }
                if (option != "1" && option != "2" && option != "3")
                {
                    Console.WriteLine("You are out of range: enter either of 1, 2, 3");
                }
               Ask:
                Console.WriteLine("Do you wish to perform another operation: enter yes/no?");
                string right = Console.ReadLine();
                right =right.ToLower();
                if (right == "yes")
                {
                    continue;
                }
                else if (right == "no")
                {
                    break;

                }
                else if (right != "yes" && right != "no")
                {
                    Console.WriteLine("Your input is invalid!");
                    
                }

                
            }
            Console.ReadKey();

        }

       
    }
}
