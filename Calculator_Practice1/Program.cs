using System;

namespace Calculator_Practice1
{
    internal class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();

            double resultAddition = calculator.Plus(10, 3);
            Console.WriteLine("Результат сложения: " + resultAddition);

            double resultSubtraction = calculator.Subtract(10, 4);
            Console.WriteLine("Результат вычитания: " + resultSubtraction);

            double resultMultiplication = calculator.Multiply(6, 7);
            Console.WriteLine("Результат умножения: " + resultMultiplication);

            double resultDivision = calculator.Divide(15, 3);
            Console.WriteLine("Результат деления: " + resultDivision);

            Console.ReadLine();
        }
    }
}
