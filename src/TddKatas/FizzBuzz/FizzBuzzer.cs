using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TddKatas.FizzBuzz
{
    public class FizzBuzzer
    {
        public string GetString(int number)
        {
            var result = string.Empty;

            if (number % 3 == 0)
                result = "Fizz";
            
            if (number % 5 == 0)
                result += "Buzz";
            
            if (string.IsNullOrWhiteSpace(result))
                result = number.ToString();

            return result;
        }

        public IEnumerable<string> ExecuteForRange(int low, int high)
        {
            for (var i = low; i <= high; i++)
            {
                yield return GetString(i);
            }
        }
    }
}
