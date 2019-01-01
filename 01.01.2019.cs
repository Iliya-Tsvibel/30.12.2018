using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print numbers from 1 to 2000
            /*
            for (int i = 1; i <= 2000; i++)
            {
                Console.WriteLine(i);
            }
            */

            // Print even numbers from 1 to 100
            /*
            for (int i = 2; i <= 100; i=i+2)
            {
                Console.WriteLine(i);
            }
            */

            // Print numbers that divided by 10 without remainder form 10 to 100. Without using %
            /*
            for (int i = 10; i <= 100; i=i+10)
            {
                Console.WriteLine(i);
            }
            */

            // Print numbers from 100 to 1
            /*
            for (int i = 100; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            */

            // Check if a include 2 numbers

            Console.WriteLine("Insert any number a to check if it include 2 numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            
            if (a>9 && a<=99)
               
            {
                if ((a%10)>(a/10))
                { 
                Console.WriteLine("ASERIOT");
                Console.WriteLine(a % 10);
                }
                else
                { 
                Console.WriteLine("AHADOT");
                Console.WriteLine(a/10);
                Console.WriteLine("Bingo!");
                }
            }
            else
            {
                Console.WriteLine("This is the not binary number");
            }
            
                
            
        }
    }
}
