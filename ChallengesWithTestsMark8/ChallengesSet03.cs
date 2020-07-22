using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            //This method returns checks the array of bool values and determines if one is false
            try
            {
                bool arrayContainsAFalse = false;
                foreach (var x in vals) 
                {if (x == false)
                    arrayContainsAFalse = true;
                }
                return arrayContainsAFalse;
            }
            catch (Exception ex)
            {
                return false;
            }  
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {//This method sums all the odd numbers in the list and determines the result is Odd or Even         
            try
            {
                var sum = numbers.Where(x => x % 2 != 0).Sum();
                if (sum % 2 == 0)                
                    return false;                
                else                
                    return true;                
            }
            catch (Exception ex)
            {
                return false;
            }            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            try
            {
                bool passwordOK = false;              
                if (password.Any(char.IsLower) && password.Any(char.IsUpper) && password.Any(char.IsDigit))
                    passwordOK = true;
               else
                    passwordOK = false;              
                return passwordOK;
            }
            catch (Exception ex)
            {
                return false;
            }
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
            try
            {
                return dividend / divisor;
            }
            catch (Exception ex)
            {
                return 0;
            }            
        }

        public int LastMinusFirst(int[] nums)
        {
            try
            {
                return (nums[nums.Length - 1] - nums[0]);
            }
            catch (Exception ex)
            {
                return 0;
            }            
        }

        public int[] GetOddsBelow100()
        {
            int[] oddArray = new int[50];            //return array 
            int i = 0;                               //index counter
            for (int num = 1; num < 100; num++)
            {
                if (num % 2 != 0)
                {
                    oddArray[i] = num;
                    i++;
                }
            }
            return oddArray;
        }    

        public void ChangeAllElementsToUppercase(string[] words)
        {            
            for (int i =0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper(); 
            }            
        }
    }
}
