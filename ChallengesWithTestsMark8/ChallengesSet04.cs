using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var oddIsNegative = numbers.Where(x => x % 2 != 0).Select(x => -x);
            var even = numbers.Where(x =>x % 2 == 0);
            return even.Sum() + oddIsNegative.Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var lst = new List<string> { str1, str2, str3, str4 };
            return lst.Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            return new List<int> { number1, number2, number3,number4 }.Min(x => x);
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return sideLength1 + sideLength2 > sideLength3 && sideLength1 + sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            bool isNum;
            double notNeeded;
            isNum = double.TryParse(input, out notNeeded);
            return isNum;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var countNull = objs.Where(x => x == null).Count();
            return countNull > objs.Count() / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) { return 0; }
            var evens = numbers.Where(x => x % 2 == 0);
            return evens.Count() != 0 ? evens.Average() : 0;
        }

        public int Factorial(int number)
        {
            if (number == 0) { return 1; }
            if (number < 0) { throw new ArgumentOutOfRangeException(); }
            for (int i = number - 1; i > 0; i--)
            {
                number *= i;
            }
            return number;
        }
    }
}
