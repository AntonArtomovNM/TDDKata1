using System;
using Xunit;
using StringCalculators;

namespace Kata1.XUnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData ("", 0)]
        [InlineData ("0", 0)]
        [InlineData ("1", 1)]
        [InlineData ("1,3", 4)]
        [InlineData ("1,3,5", 9)]
        [InlineData ("1\n2,3", 6)]

        public void AddNumsCorrect(string numbers, int expected)
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add(numbers);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("//;\n1;2", 3)]
        public void AddNumbersWithDelimiter(string numbers, int expected)
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add(numbers);

            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData("//;\n-1;2")]
        [InlineData("//;\n-1;-2" )]
        public void AddNegativeNumbers(string numbers)
        {
            StringCalculator calculator = new StringCalculator();

            Action action =()=> calculator.Add(numbers);

            Assert.Throws<ArgumentException>(action);
        }
    }
}
