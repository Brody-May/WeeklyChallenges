using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null) 
            {
                return false;
            }
            foreach (var item in vals) 
            { 
                if (item == false) 
                {
                    return true;
                }
            }
            return false;
            
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
           int sum = 0;
            foreach (var number in numbers) 
            { 
                if (number % 2 != 0) 
                {
                    sum += number;
                }
            }
            if (sum % 2 != 0) 
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLower = false;
            bool isDigit = false;
            bool isUpper = false;

            foreach(var ch in password) 
            { 
                if (char.IsLower(ch)) 
                { 
                    isLower= true;
                }
                if (char.IsDigit(ch)) 
                { 
                    isDigit= true;
                }
                if (char.IsUpper(ch)) 
                { 
                    isUpper= true;
                }
            }
            if (isLower && isUpper && isDigit) 
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
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) 
            {
                return 0;
            }
            else 
            { 
                return dividend / divisor;  
            }
        }


        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
            var list = new List<int>();
            for (int i = 1; i < 100; i++) 
            { 
                if (i % 2 !=0) 
                { 
                    list.Add(i);
                }
            }
            return list.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0 ; i < words.Length; i++) 
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
