using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    sum += numbers[i];
                } else
                {
                    sum -= numbers[i];
                }
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int shortestLength = str1.Length;
            if (str2.Length < shortestLength) { shortestLength = str2.Length; }
            if (str3.Length < shortestLength) { shortestLength = str3.Length; }
            if (str4.Length < shortestLength) { shortestLength = str4.Length; }
            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallestNum = number1;
            if (number2 < smallestNum) { smallestNum = number2; }
            if (number3 < smallestNum) { smallestNum = number3; }
            if (number4 < smallestNum) { smallestNum = number4; }
            return smallestNum;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            //if (biz.Name != "TrueCoders")
            //{
                biz.Name = "TrueCoders";
            //}
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool isTriangle = true;
            if (sideLength1 + sideLength2 <= sideLength3) { isTriangle = false; }
            if (sideLength2 + sideLength3 <= sideLength1) { isTriangle = false; }
            if (sideLength3 + sideLength1 <= sideLength2) { isTriangle = false; }
            return isTriangle;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null) { return false; }
            bool isNumber = double.TryParse(input, out double numValue);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int countNulls = 0;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    ++countNulls;
                }
            }
            bool result = countNulls > (objs.Length / 2);
            return result;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) { return 0; }
            double countEvens = 0;
            double sumEvens = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]%2 == 0)
                {
                    sumEvens += numbers[i];
                    ++countEvens;
                }
            }
            if (countEvens == 0) { return 0; }
            double result = sumEvens / countEvens;
            return result;
        }

        public int Factorial(int number)
        {
            if (number == 0) { return 1; }
            if (number < 0) { throw new ArgumentOutOfRangeException(); }
            int factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
