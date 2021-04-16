using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            bool containsAFalse = false;
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false) { containsAFalse = true; }
            }
            return containsAFalse;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            int sum = 0;
            if (numbers == null) { return false; }
            foreach (int num in numbers)
            {
                if (num%2 != 0) { sum += num; }
            }
            return Convert.ToBoolean(sum % 2);
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(char.IsLower) && password.Any(char.IsDigit))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
            char[] charArr = val.ToCharArray();
            return charArr[0];
        }

        public char GetLastLetterOfString(string val)
        {
            char[] charArr = val.ToCharArray();
            return charArr[charArr.Length-1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) { return 0; }
            return (dividend / divisor);
        }

        public int LastMinusFirst(int[] nums)
        {

            return (nums[nums.Length-1] - nums[0]);
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = new int[50];
            for (int i = 1; i <= odds.Length; i++)
            {
                odds[i-1] = (i * 2) - 1;
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
