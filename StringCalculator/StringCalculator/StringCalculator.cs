using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StringCalculators
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            var numbersArray = numbers.Trim().Split(',').Select(x => int.Parse(x));
            return numbersArray.Aggregate((x, y) => x + y);
        }
    }
}
