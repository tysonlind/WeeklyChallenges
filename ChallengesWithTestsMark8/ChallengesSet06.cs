using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if(words != null)
            {
                if (ignoreCase)
                {
                    foreach (string checkedWord in words)
                    {
                        if (checkedWord != null)
                        {
                            if (checkedWord.ToLower() == word.ToLower())
                            {
                                return true;
                            }
                        }

                    }
                    return false;
                }

                foreach (string checkedWord in words)
                {
                    if (checkedWord != null)
                    {
                        if (checkedWord == word)
                        {
                            return true;
                        }
                    }

                }
                return false;
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {

            if (num < 2) return false;


            for (int i = 2; i * i <= num; i++)
            {


                if (num % i == 0) return false;
            }


            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str)) return -1;

            Dictionary<char, int> charMap = new Dictionary<char, int>();

            
            foreach (char c in str)
            {
                if (charMap.ContainsKey(c))
                {
                    charMap[c]++;
                }
                else
                {
                    charMap[c] = 1;
                }
            }

          
            for (int i = str.Length - 1; i >= 0; i--)
            {
                if (charMap[str[i]] == 1)
                {
                    return i; 
                }
            }

            return -1; 
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            int maxCount = 1;
            int currentCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {

                if (numbers[i] == numbers[i - 1])
                {

                    currentCount++;

                    if (currentCount > maxCount) maxCount = currentCount;
                }
                else
                {

                    currentCount = 1;
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            
            List<double> result = new List<double>();

            if (elements == null || elements.Count == 0 || n < 0 || n > elements.Count) return result.ToArray();

            int i = n - 1;

            while (i < elements.Count)
            {
                result.Add(elements[i]);
                i += n;
            }

            return result.ToArray();
        }
    }
}
