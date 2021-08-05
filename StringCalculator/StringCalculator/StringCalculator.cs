using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StringCalculators
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
                return 0;

            Regex reg = new Regex(@"//[\W\w]\n[\W\w]+");
            List<char> delimiter = new List<char>() { ',', '\n', ';' };
            if (reg.IsMatch(numbers));
                delimiter.Add(Char.Parse(numbers.Substring(2, 3)));

            string str = numbers.Split('\n').LastOrDefault();

            var numbersArray = str.Trim().Split(delimiter.ToArray(),
                                                StringSplitOptions.RemoveEmptyEntries)
                                                .Select(x => int.Parse(x));
            return numbersArray.Aggregate((x, y) => x + y);
        }
    }
}
