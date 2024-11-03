using System;

namespace ConsoleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to your cmd calculator!");
            Console.WriteLine("start by input a number!");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter your mathematical operator");

            string mathOperator = Console.ReadLine();

                if (mathOperator != "+" || mathOperator != "-" || mathOperator != "*" || mathOperator != "/")
                {
                    Console.WriteLine("Invalid input try again");
                }
                else
                {
                    Console.WriteLine("Enter you second number");
                    int secondNumer = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("The mathematical equation is: ");
                    switch (mathOperator)
                    {
                        case "+":
                            Console.WriteLine(firstNumber + secondNumer);
                            break;
                        case "-":
                            Console.WriteLine(firstNumber - secondNumer);
                            break;
                        case "*":
                            Console.WriteLine(firstNumber * secondNumer);
                            break;
                        case "/":
                            Console.WriteLine(secondNumer / firstNumber);
                            break;
                    }
                }
        }
    }
}
