using System;

namespace StringCalculators
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = "//;\n1;2";
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add(numbers);

        }
    }
}
