using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Count() % 2 == 0;
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
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            return numbers.Min() + numbers.Max(); 
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            return str1.Length < str2.Length ? str1.Length : str2.Length;
        }

        public int Sum(int[] numbers)
        {
            return numbers != null ? numbers.Sum() : 0;
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            int[] nums = new int[numbers.Length];
            int count = 0;
            foreach (int n in numbers)
            {
                if (n % 2 == 0)
                {
                    nums[count] = n;
                    count++;
                }
            }
            return nums.Sum();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            return numbers.Sum() % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}
