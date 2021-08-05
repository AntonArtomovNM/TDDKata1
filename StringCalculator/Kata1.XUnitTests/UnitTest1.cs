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
        [InlineData("//;\n1;2", 3)]
        public void AddNumsCorrect(string numbers, int expected)
        {
            StringCalculator calculator = new StringCalculator();

            var actual = calculator.Add(numbers);

            Assert.Equal(expected, actual);
        }
    }
}
