using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = startNumber + 1;
            int nextDivByN = 0;
            do {
                if (nextNumber % n == 0) {
                    nextDivByN = nextNumber;
                }
                ++nextNumber;
            } while (nextDivByN == 0);
            return nextDivByN;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (int i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            bool isAscending = true;
            if (numbers == null || numbers.Length == 0) { return false; }
            if (numbers.Length == 1) { return true; }
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i-1]) { return false; }
            }
            return isAscending;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return 0; }
            int sum = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if (numbers[i] % 2 == 0) { sum += numbers[i + 1]; }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) { return ""; }
            if (words[0] == " ") { return ""; }

            string sentence = "";
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim();
                if (words[i] != "") {
                    if (i < words.Length - 1) {
                        sentence = sentence + words[i] + " ";
                    } else {
                        sentence = sentence + words[i] + ".";
                    }
                }
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null ) { return new double[] { }; }
            var newList = new List<double> { };
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i+1)%4 == 0)
                {
                    newList.Add(elements[i]);
                }
            }
            return newList.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length == 0) { return false; }

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i+1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber) { return true; }
                }
            }
            return false;
        }
    }
}
