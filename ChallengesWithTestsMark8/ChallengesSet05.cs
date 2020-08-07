using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            //Starting with startNumber +1, Find the next Number Divisible by N
            int nextDivisible = 0;
            int checkNum = startNumber +1;
            while (nextDivisible == 0)
            {
                if (checkNum % n == 0) 
                {
                    nextDivisible = checkNum;
                }
                checkNum = checkNum + 1;
            }
            return nextDivisible;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (var b in businesses)
            {
                if (b.TotalRevenue == 0) 
                {
                    b.Name = "CLOSED";
                }
            }           
        }
        
        public bool IsAscendingOrder(int[] numbers)
        {
            bool isAscendingOrder = true;
            if (numbers == null || numbers.Length == 0)
            {
                isAscendingOrder = false;
            }
            else 
            {
                int compareNum = numbers[0];
                foreach (var n in numbers)
                {
                    if (compareNum <= n)
                    {
                        compareNum = n;
                    }
                    else
                    {
                        isAscendingOrder = false;
                    }
                }            
            }
            return isAscendingOrder;      
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            int sum = 0;
            if (numbers == null || numbers.Length == 0)
            {
                sum = 0;
            }
            else 
            {
                bool addNext = false;
                foreach (var n in numbers)
                {
                    if (addNext == true)
                    {
                        sum = sum + n;
                    }
                    if (n % 2 == 0)
                    {
                        addNext = true;
                    }
                    else
                    {
                        addNext = false;
                    }
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {// Passed all tests but not clean logic
           
            StringBuilder sb = new StringBuilder("");         
                        
            if (words == null || words.Length == 0)
            {
                return sb.ToString();
            }
            else
            {
                int i = 0;
                while (i < words.Length)
                {
                    if (words[i] == "" || words[i] == " " || words[i] == "  ")
                        i = i + 1;
                    else
                    {
                        sb.Append(words[i].Trim());
                        if (i == words.Length - 1)
                            sb.Append(".");
                        else
                            sb.Append(" ");
                        i = i + 1;
                    }                    
                }
                return sb.ToString();
            }                       
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> fourthelement = new List<double>();            //return array 

            if (elements == null )
            {
                return fourthelement.ToArray();
            }

            if (elements.Count >= 4)
            {
                var elecount = 1;
                for (int i = 0; i < elements.Count; i++)
                { if (elecount == 4)
                    {
                        fourthelement.Add(elements[i]);
                        elecount = 1;
                    }
                    else    
                    elecount = elecount + 1;
                }                
                return fourthelement.ToArray();
            }
            else
            return fourthelement.ToArray();            
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            bool sumtarget = false;
            if (nums.Length != 1) 
            { 
                for (int i = 0; i < nums.Length; i++) 
                {
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        if (nums[i] + nums[j] == targetNumber) 
                        {
                            sumtarget = true;
                        }
                    }
                }
            }
            return sumtarget;
        }
    }
}
