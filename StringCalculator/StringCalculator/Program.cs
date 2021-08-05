using System;

namespace StringCalculators
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "//;\n-1;-2";
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add(numbers);

        }
    }
}
