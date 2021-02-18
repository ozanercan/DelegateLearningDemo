using System;
using System.Linq;

namespace DelegeLearningDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            var @delegate = new CalculateHandler(Multiply);
            total = @delegate.Invoke(4, 2, 3);

            Console.WriteLine(total);
        }

        public delegate double CalculateHandler(params double[] numbers);

        public static double Sum(params double[] numbers)
        {
            return numbers.Sum();
        }

        public static double Multiply(params double[] numbers)
        {
            double total = 1;
            foreach (var number in numbers)
                total *= number;

            return total;
        }
    }
}
