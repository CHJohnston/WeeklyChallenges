using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            try
            {
                int total = 0;               
                foreach (var i in numbers)
                {
                    if (i % 2 == 0)
                         total = total + i;
                    else
                        total = total - i;                    
                }
                return total;
            }
            catch (Exception ex)
            {
                return 0;
            }            
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int[] stringlength = new int[] { str1.Length, str2.Length, str3.Length, str4.Length };
            return stringlength.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int[] numbers = new int[] { number1, number2, number3, number4 };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool isTriangle = false;
            if (sideLength1 + sideLength2 > sideLength3)
            {
                if (sideLength1 + sideLength3 > sideLength2)
                {
                    if (sideLength2 + sideLength3 > sideLength1)
                    {
                        isTriangle = true;
                    }
                }
            }
            return isTriangle;
        }

        public bool IsStringANumber(string input)
        {
            bool isNum = false;           

            if (int.TryParse(input, out int intNum))
                isNum = true;
            else
            {
                if (decimal.TryParse(input, out decimal decNum))
                    isNum = true;
            }
            return isNum;
        }     
              

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var countnull = objs.Where(x => x == null).Count();
            var countNotNull = objs.Where(x => x != null).Count();
            if (countnull > countNotNull)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {           
            double avgEvens = 0;
            try
            {
                var avgevens = numbers.Where(x => x % 2 == 0).Average();
                avgEvens = avgevens;
            }
            catch (Exception ex)
            {
                avgEvens = 0;
            }
            return avgEvens;
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                if (number == 0)
                {
                    return 1;
                }
                else
                {
                    int factorial = number;
                    int n = number-1;
                    while (n > 1)
                    {
                        factorial = factorial * n;
                        n--;
                    }
                    return factorial;
                }
            }   
        }                    
    }
}
