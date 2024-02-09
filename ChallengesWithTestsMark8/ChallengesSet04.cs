using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                } else if (numbers[i]  % 2 == 1)
                {
                    sum -= numbers[i];
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestString = str1.Length;
            List<string> stringList = new List<string>() { str1, str2, str3, str4 };

            for (int i = 1; i < stringList.Count; i++)
            {
                if (stringList[i].Length < shortestString)
                {
                    shortestString = stringList[i].Length;
                }
            }
            return shortestString;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;
            List<int> myNums = new List<int>() { number1, number2, number3, number4 };
            for (int i = 1; i < myNums.Count; i++)
            {
                if (myNums[i] < smallest)
                {
                    smallest = myNums[i];
                }
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
            return;
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength2 + sideLength3 > sideLength1 && sideLength3 + sideLength1 > sideLength2)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            return double.TryParse(input, out double output);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    nullCount++;
                }
            }
            if (nullCount > objs.Length / 2)
            {
                return true;
            }
            return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            var numSet = numbers.Where(n => n % 2 == 0).ToList();
            if (numSet.Count > 0)
            {
                return numSet.Average();
            }
            return 0;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number <= 1)
            {
                return 1;
            } else
            {
                return number * Factorial(number - 1);
            }
        }
    }
}
