﻿namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;


            while ( n > 0 )

            {
                int digit = n % 10;
                sum += digit;
             
                n = n / 10;
                
                
                


            }
            Console.WriteLine(sum);
        }
    }
}