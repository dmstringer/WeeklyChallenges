﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Management.Automation;

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
            if (vals.Length%2 == 0) {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
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
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            int sum = 0;

            if (numbers == null)
            {
                return sum;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }

            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            if (numbers == null)
            {
                return sum;
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0) {
                    sum += numbers[i];
                }
            }
            return sum;
        }
        
        public bool IsSumOdd(List<int> numbers)
        {
            //if (!numbers.Any()) 
            //{
            //    return false; 
            //}

            if (numbers == null)
            {
                return false;
            }

            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            return Convert.ToBoolean(sum%2);
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number > 0) {
                return number / 2;
            } else
            {
                return 0;
            }
        }
    }
}
