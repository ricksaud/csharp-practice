using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Calculator Console");
            Console.WriteLine("Type 'exit' if you want to leave the app at any moment");


            bool keepGoing = true;


            while (keepGoing)
            {
                Console.WriteLine();
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1 - Add");
                Console.WriteLine("2 - Subtract");
                Console.WriteLine("3 - Multiply");
                Console.WriteLine("4 - Divide");
                Console.Write("Option (or 'exit'): ");

                string option = Console.ReadLine();

                if (option.ToLower() == "exit")
                {
                    keepGoing = false;

                    //Continue stops the loops and keep going in the code
                    continue;
                }



                Console.WriteLine("Choose the first number for your operation");
                string number1Text = Console.ReadLine();

                bool isValidNumber = double.TryParse(number1Text, out double number1);

                if (isValidNumber == false)
                {
                    Console.WriteLine("That is not a valid number");
                    continue;
                }


                Console.WriteLine("Choose the second number for your operation");
                string number2Text = Console.ReadLine();

                bool isValidNumber2 = double.TryParse(number2Text, out double number2);

                if (isValidNumber2 == false)
                {
                    Console.WriteLine("That is not a valid number");
                    continue;
                }


                double result = 0;

                switch (option)
                {
                    case "1":
                        result = Add(number1, number2);
                        break;

                        case "2":
                            result = Subtract(number1, number2);
                        break;

                        case "3":
                            result = Multiply(number1, number2);
                        break;
                        case "4":
 

                            result = Divide(number1, number2);
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        continue;
                }



                Console.WriteLine($"Result is {result}");



          










            }

            Console.WriteLine("Finished the Calculator");
        }
    

    static double Add(double a, double b)
        {

            return a + b;
        }


        static double Subtract(double a, double b)
        {

            return a - b;
        }

        static double Multiply(double a, double b)
        {

            return a * b;
        }

        static double Divide (double a, double b)
        {


            if(b == 0)
            {

                Console.WriteLine("Error: Cannot divide by zero");
                return 0;

            }
            else {

                return a / b;
            }
        }

    }

}


