using System;

namespace Calculator_Practice1
{
    internal class Program
    {
        static void Main()
        {
            Calculator calculator = new Calculator();
            Degree3 degree3 = new Degree3();
            Degree2 degree2 = new Degree2();

            double resultAddition = calculator.Plus(10, 3);
            Console.WriteLine("Результат сложения 10+3: " + resultAddition);

            double resultSubtraction = calculator.Subtract(10, 4);
            Console.WriteLine("Результат вычитания 10-4: " + resultSubtraction);

            double resultMultiplication = calculator.Multiply(6, 7);
            Console.WriteLine("Результат умножения 6*7: " + resultMultiplication);

            double resultDivision = calculator.Divide(15, 3);
            Console.WriteLine("Результат деления 15/3: " + resultDivision);

            double resultSquare = degree2.Square(4);
            Console.WriteLine("Результат возведения в квадрат 4^2: " + resultSquare);

            double resultSquare2 = degree3.Square2(4);
            Console.WriteLine("Результат возведения в квадрат 4^3: " + resultSquare2);

            Console.ReadLine();
        }
    }
}
