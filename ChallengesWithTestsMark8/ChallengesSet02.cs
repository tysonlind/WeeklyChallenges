using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }
        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0 )
            {
                return true;
            }
            return false;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

            if (numbers == null || !numbers.Any())
            {
                return 0;
            }

            return numbers.Max() + numbers.Min();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            List<string> strings = new List<string>() { str1, str2 };
            return strings.Min(s => s.Length);
        }

        public int Sum(int[] numbers)
        {
            return numbers?.Sum() ?? 0;
        }

        public int SumEvens(int[] numbers)
        {
            return numbers?.Where(n => n % 2 == 0).Sum() ?? 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if(numbers == null || !numbers.Any())
            {
                return false;
            }

            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            return Math.Abs(sum) % 2 == 1;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int count = 0;

            for (long i = number - 1; i >= 0; i--)
            {
                if ( i % 2 == 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
