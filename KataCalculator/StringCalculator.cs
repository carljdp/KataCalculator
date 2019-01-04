using System;
using System.Security.Cryptography.X509Certificates;

namespace KataCalculator

{
    public static class StringCalculator
    {
        public static void Main(string[] args)
        {
  
        }

        public static int Add(string str)
        {
            var number = 0;
            
            if (string.IsNullOrEmpty(str))
            {
                return number;
            }
            
            // Split input string
            var strNumbers = str.Split(',');
            
            if (strNumbers.Length >= 1)
            {
                foreach (var strNumber in strNumbers)
                {
                    number = number + int.Parse(strNumber);
                }
            }
            
           return number;
        }
    }
}