using System;

namespace calculatorSWT
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Hello World!");

            Calculator calc = new Calculator();

            double addRes = calc.Add(5, 6);
            double subRes = calc.Subtract(8, 9);
            double mulRes = calc.Multiply(5, 2);
            double powRes = calc.Power(2, 6);

            Console.WriteLine("5+6 = ", addRes);
            Console.WriteLine("8-9 = ", subRes);
            Console.WriteLine("5*2 = ", mulRes);
            Console.WriteLine("2 raised to 6 = ", powRes);
        }
    }
}
