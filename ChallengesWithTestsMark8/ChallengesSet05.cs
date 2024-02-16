using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextDivisible = startNumber + 1;

            while (nextDivisible % n != 0)
            {
                nextDivisible++;
            }
            return nextDivisible;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business biz in businesses)
            {
                if (biz.TotalRevenue <= 0)
                {
                    biz.Name = "CLOSED";
                }
            }
            return;
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            try
            {
                if (numbers.Length == 0)
                {
                    return false;
                }
            } catch (NullReferenceException)
            {
                return false;
            }
            
            var orderedNums = numbers.OrderBy(n => n).ToList();

            for (int i = 0; i < orderedNums.Count(); i++)
            {
                if (orderedNums[i] != numbers[i])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers != null)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i + 1];
                    }
                }
                return sum;
            }
            return 0;
            
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return string.Empty;
            }

            // Use LINQ to filter out null or empty strings, trim extra spaces, and concatenate
            var sentence = string.Join(" ", words
                                            .Where(word => !string.IsNullOrWhiteSpace(word))
                                            .Select(word => word.Trim()));

            // Return the resulting sentence
            if(sentence.Length > 0 )
            {
                return sentence += ".";
            }

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();
            if (elements != null)
            {
                
                int i = 3;
                while (i < elements.Count)
                {
                    result.Add(elements[i]);
                    i += 4;
                }

                
            }
            return result.ToArray();

        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2) // Check if the array is null or too short
            {
                return false;
            }

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++) 
                {
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }

            return false;

        }
    }
}
