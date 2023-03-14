using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null || words.Contains(null)) return false; //null check
            var match = false;
            if (ignoreCase)
            {
                foreach (var search in words)
                {
                    if (search.ToLower() == word.ToLower())
                    {
                        match = true;
                        break;
                    }
                    match = false;
                }
            }
            if (!ignoreCase)
            {
                foreach (var search in words)
                {
                    if (search == word)
                    {
                        match = true;
                        break;
                    }
                    match = false;

                }
            }
            return match;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (str.Length == 1) return 0;
            if (str.Length == 0 || str.Distinct().Count() == 1) return -1;
            var index = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if ((str.Count(x => x == str[i]) == 1)) //save last index of unique char
                {
                    index = i;
                }
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            var most = 0;
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                int count = 1;
                for (int j =  i + 1; j <= numbers.Length - 1; j++)
                {
                    if (numbers[i] != numbers[j])
                    {
                        break;
                    }
                    count++;                       
                }
                if (count > most)
                {
                    most = count;
                }
            }
            return most;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
            {
                return new double[0];
            }
            List<double> result = new();
            for (int i = 0; i < elements.Count;)
            {
                i += n;
                if (i > elements.Count)
                {
                    break;
                }
                result.Add(elements[i - 1]);
            }
            return result.ToArray();
        }
    }
}
