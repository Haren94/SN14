using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb_2
{
    class Program
    {
        static void Main(string[] args)
        {

           //Rader
            for (int row = 0; row < 25; row++)
            {
               switch (row % 3)
               {
                   case 0:
                       Console.ForegroundColor = ConsoleColor.Yellow;
                       break;

                   case 1:
                       Console.ForegroundColor = ConsoleColor.Magenta;
                       break;

                   case 2:
                       Console.ForegroundColor = ConsoleColor.Green;
                       break;

               }


            //varannan rad
            if (row % 2 == 1)
            {
                Console.Write(" ");
            }



            //kolummner
            for (int col = 0; col < 39; col++)
            {
                Console.Write("* ");
            }


            Console.WriteLine();
            Console.ResetColor();

            }

        }
    }
}
