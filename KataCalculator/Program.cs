using System;
using System.Security.Cryptography.X509Certificates;

namespace KataCalculator

{
    public static class Program
    {
        public static void Main(string[] args)
        {
            
            
        }

        public static int Add(string str)
        {
            var number = 0;
            
            try
            {
                number = int.Parse(str);
            }
            catch
            {
                throw;
            }


            return number;
        }
        
        
        
    }



}