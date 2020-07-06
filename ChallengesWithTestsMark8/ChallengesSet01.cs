using System;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    //Complete -- All Tests Passed!
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            //Complete - This Method returns a bool (true or false) if two integers are the same
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //Complete - This method Subtracts one number from another
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            //Complete - This method adds two intergers
            return number1 + number2;
        }

        public int GetSmallestNumber(int number1, int number2)
        {   //Complete - This method determines the smaller of two integers
            if (number1 < number2)
            {
                return number1;
            }
            else 
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {
            //Complete - This Method multiplies two numbers and returns the product
            return factor1 * factor2;            
        }

        public string GetGreeting(string nameOfPerson)
        {
            //Complete - This Method Returns "Hello" with the name of the person
          
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else 
            {
                return "Hello, " + nameOfPerson + "!";
            }        
        }

        public string GetHey()
        {
            return "HEY!";
        }
    }
}
