using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            for (int i = startNumber + 1; ; i++) //compare, starting at index 1, to previous number
            {
                if (i % n == 0)
                {
                    return i;
                }
            }
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i =0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == null || businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            } //void, no return needed
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length <= 0) return false; //null check
            if (numbers.Length == 1) return true; //to cover 1 item array
            bool isAsc = false; //default value
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] >= numbers[i - 1])
                {
                    isAsc = true; //establish that all prior numbers in array are ascending
                }
                if (numbers[i] <  numbers[i - 1])
                {
                    isAsc = false;
                    break; //skips to return statement should the iteration find a number not in asc order
                }
            }
            return isAsc;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0; //null check
            var sum = 0;
            for (int i = 1;  i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0) //check that prior number is even
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            //var word = ""; debug variable
            if (words == null || words.Length == 0) return "";
            var wordList = words.ToList(); //so that items can be removed
            for (int i = wordList.Count - 1; i >= 0; i--) //decrement to start at end of list so index is not off
            {
                if (wordList[i] == " " || wordList[i] == "") //remove spaces and empty strings
                {
                    wordList.RemoveAt(i);
                }
            }
            for (int i = 0; i < wordList.Count; i++)
            {
                wordList[i] = wordList[i].Trim(); //remove whitespace around words
                //word = wordList[i]; used to debug, check the values of each word after Trim()
            }
            for (int i = wordList.Count - 1; i >= 0; i--)
            {
                if (wordList[i] == " " || wordList[i] == "")
                {
                    wordList.RemoveAt(i); //secondary removal to cover for escaped empty strings
                }
            }
            if (wordList.Count == 0) return ""; //to cover Lists that held nothing but empty strings
            return string.Join(" ", wordList) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0) return new double[] { }; //null check
            List<double> fourth = new(); //use list to avoid allocating length to array
            for (int i = 3; i < elements.Count; i += 4) //to access every fourth element
            {
                fourth.Add(elements[i]);
            }
            return fourth.ToArray(); //return as array
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            //var bug = 0; debugging variable
            if (nums == null || nums.Length <= 1) return false; //null check
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1; j < nums.Length; j++)
                {
                    //bug = nums[i] + nums[j]; debugging, check values being added together
                    if (nums[i] + nums[j] == targetNumber && i != j) //assert the targetNumber, AND that the numbers being added
                    {                                                //are not the same number (same index from the array)

                        return true;
                    }
                }
            }
            return false;
        }
    }
}
