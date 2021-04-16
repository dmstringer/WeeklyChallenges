using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) { return false; }
            foreach (string wrd in words)
            {
                if (wrd != null)
                {
                    if (ignoreCase)
                    {
                        if (wrd.ToLower() == word.ToLower()) { return true; }
                    } else
                    {
                        if (wrd == word) { return true; }
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) { return false; }
            int divisible = 0;
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0) { divisible++; }
            }
            if (divisible == 2) { return true; }
            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int indexUnique = -1;
            for (int i = 0; i < str.Length; i++)
            {
                int numFound = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j]) { ++numFound; }
                }
                if (numFound == 1) { indexUnique = i; }
            }
            return indexUnique;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int consCount = 1;
            int tempCount = 1;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i-1]) 
                {
                    ++tempCount;
                } else
                {
                    if (tempCount > consCount) { consCount = tempCount; }
                    tempCount = 1;
                }
            }
            if (tempCount > consCount) { consCount = tempCount; }
            return consCount; //{ 1, 2, 2, 3, 3, 3, 3 }, 4)]
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n < 1) { return new double[] { }; }
            var newList = new List<double> { };
            for (int i = 0; i < elements.Count; i++)
            {
                if ((i + 1) % n == 0)
                {
                    newList.Add(elements[i]);
                }
            }
            return newList.ToArray();
        }
    }
}
