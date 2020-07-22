using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            try
            {
                bool characterisaletter = false;
                Regex r = new Regex("^[a-zA-Z]*$");
                if (r.IsMatch(c.ToString()))
                {
                    characterisaletter = true;
                }
                else
                {
                    characterisaletter = false;
                }
                return characterisaletter;
            }
            catch (Exception ex)
            {
                return false;
            }
            //return Char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {//This Method returns a bool of true if the count of the list is even
            try
            {               
                if (vals.Count() % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            //  Checks a integer and returns a bool=true if even

            //  This uses the Ternary Operator 
            //  return number % 2 == 0 ? true : false;

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
            //  Checks a integer and returns a bool=true if odd
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
            //This method returns the sum of the min and max values of the array
            try
            {
                return numbers.Max(x => x) + numbers.Min(x => x);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {//This method returns the number of characters in the shortest string
            try
            {   if (str1.Length < str2.Length)
                {
                    return str1.Length;
                }
                else
                {
                    return str2.Length;
                }              
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int Sum(int[] numbers)
        {//This method returns the sum the integers in the array 
            //if (numbers == null)
            //{
            //    return 0;
            //}
            //else
            //{
            //    int sum = 0;
            //    foreach (var num in numbers)
            //    {
            //        sum += num;
            //    }
            //    return sum;
            //}

            // Here is the same method using the Try /Catch
            // Tried catching ArgumentNullException instead of Exception, but it didn't work
            //
            //try
            //{
            //    int sum = 0;
            //    foreach (var num in numbers)
            //    {
            //        sum += num;
            //    }
            //    return sum;
            //}            
            //catch(Exception ex)
            //{
            //    return 0;
            //}

            //Here is the same Method using Linq Extensions
            try
            {                
                return numbers.Sum(x => x);
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int SumEvens(int[] numbers)
        {//This Method sum the even numbers in the list
            try
            {
                var evens = numbers.Where(x => x % 2 == 0);
                return evens.Sum(x => x);               
            }
            catch (Exception ex)
            {
                return 0;
            }            
        }

        public bool IsSumOdd(List<int> numbers)
        {//This Method returns a bool of true if the sum of the list is odd
            try
            {
                var sum = numbers.Sum(x => x);
                if (sum % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }   
            }
            catch (Exception ex)
            {
                return false;
            }    
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {//This is count of the positive odd numbers below the number passed to the method
            try
            {
                if (number > 0)
                {
                    return number / 2;
                }
                else
                {
                    return 0;
                }    
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
