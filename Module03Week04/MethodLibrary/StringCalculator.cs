using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodLibrary
{
    public class StringCalculator
    {
        public static int Add(string numbers)
        {
            int result = 0;
            char delimiter = ExtractDelimiter(numbers);
            if (!delimiter.Equals(','))
            {
                numbers = RemoveDelimiter(numbers);
            }

            if (string.IsNullOrEmpty(numbers))
            {
                result = 0;
                return result;
            }

            if (!numbers.Contains(delimiter))
            {
                int intValue = int.Parse(numbers);
                result = intValue;
            }
            else
            {
                string[] values;

                if (numbers.Contains('\n'))
                {
                    values = numbers.Split(new char[] { delimiter, '\n' }, StringSplitOptions.RemoveEmptyEntries);
                }
                else
                {
                    values = numbers.Split(delimiter).ToArray();
                }

                result = CheckForNegativeNumbers(values);
            }
            return result;
        }

        private static char ExtractDelimiter(string numbers)
        {
            if (!numbers.Contains("//"))
            {
                return ',';
            }
            else
            {
                return numbers[2];
            }
        }

        private static string RemoveDelimiter(string numbers)
        {
            return numbers.Substring(3);
        }

        private static int CheckForNegativeNumbers(string[] values)
        {
            int result;
            int[] negativeNumbers = values
                .Select(x => int.Parse(x))
                .Where(x => x < 0)
                .ToArray();


            if (negativeNumbers.Count() > 0)
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append("Negatives not allowed");
                foreach (int number in negativeNumbers)
                {
                    stringBuilder.Append(" ");
                    stringBuilder.Append(number.ToString());
                }
                throw new InvalidOperationException(stringBuilder.ToString());
            }
            else
            {
                result = values.Sum(x => int.Parse(x));
            }
            return result;
        }
    }
}
