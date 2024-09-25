using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabC_Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator App!");
            Console.WriteLine("Please select an operation:");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");

            string operation = Console.ReadLine();

            if (operation == "1" || operation == "2" || operation == "3" || operation == "4")
            {
                Console.Write("Enter the first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter the second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (operation)
                {
                    case "1":
                        result = Add(num1, num2);
                        Console.WriteLine($"The result of {num1} + {num2} = {result}");
                        break;
                    case "2":
                        result = Subtract(num1, num2);
                        Console.WriteLine($"The result of {num1} - {num2} = {result}");
                        break;
                    case "3":
                        result = Multiply(num1, num2);
                        Console.WriteLine($"The result of {num1} * {num2} = {result}");
                        break;
                    case "4":
                        result = Divide(num1, num2);
                        if (num2 != 0)
                        {
                            Console.WriteLine($"The result of {num1} / {num2} = {result}");
                        }
                        else
                        {
                            Console.WriteLine("Error: Division by zero.");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number from 1 to 4.");
            }
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static double Subtract(double x, double y)
        {
            return x - y;
        }

        static double Multiply(double x, double y)
        {
            return x * y;
        }

        static double Divide(double x, double y)
        {
            return x / y;
        }
    }
}