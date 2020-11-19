using System;

namespace hello_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = AddNumber(64, 32);
            Console.WriteLine(result);
        }

        private static int AddNumber(int numberOne, int numberTwo)
        {
            int calculationResult;
            calculationResult = numberOne + numberTwo;
            return calculationResult;
        }
    }
}
