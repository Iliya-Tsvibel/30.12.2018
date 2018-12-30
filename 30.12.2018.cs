using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3012
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             F1();

         }

         private static void F1()
         {
             for (int i = 0; i <= 200; i = i + 2)
             {
                 Console.WriteLine(i);
             }
             */

            /*
            NewMethod();
        }

        private static void NewMethod()
        {
            F2();
        }

        private static void F2()
        {
            for (int i = 1120; i > 0; i = i - 7)
            {
                Console.WriteLine(i);
            }
            */
            int x;

            int y;

            do


            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());

            }



            while (x % y != 0);

            


                Console.WriteLine(x / y);
            

        }
    }

}