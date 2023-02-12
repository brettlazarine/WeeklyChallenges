using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return Array.Exists(vals, element => element == false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null) return false;
            return numbers.Sum() % 2 != 0 ? true: false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var lower = "abcdefghijklmnopqrstuvwxyz";
            var upper = lower.ToUpper();
            var number = "1234567890";
            var hasLower = 0;
            var hasUpper = 0;
            var hasNumber = 0;
            foreach (var character in password)
            {
                if (lower.Contains(character))
                {
                    hasLower = 1;
                }
                if (upper.Contains(character))
                {
                    hasUpper = 1;
                }
                if (number.Contains(character))
                {
                    hasNumber = 1;
                }
            }
            return hasLower + hasUpper + hasNumber == 3 ? true : false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            var j = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 != 0) {
                    odds[j] = i;
                    j++;
                }
            }
            return odds;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
