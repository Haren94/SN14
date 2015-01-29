using System;

namespace Kvitto
{
    class Program
    {
        static void Main(string[] args)
        {
         
            //variabler
            double total = 0;
            int paid = 0;
            double rounding = 0;
            int change = 0;
            double subtotal = 0;

            //läser in värde från tangentbord
            while (true)
            {
                try
                {
                    Console.Write("Ange totalsumma: ");
                    total = double.Parse(Console.ReadLine());
                    break;
                }
                
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Var vänlig tryck in ett siffer värde");
                    Console.ResetColor();
                }
            }


            if (total < 1)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Total summan är för liten");
                Console.ResetColor();
                return;
            }

            while (true)
            {
                try
                {
                    Console.Write("Ange erhållet belopp: ");
                    paid = int.Parse(Console.ReadLine());
                    break;
                }

                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Erhållet belopp felaktigt.");
                    Console.ResetColor();
                }
            }

            if (paid < total)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras.");
                Console.ResetColor();
                return;
            }


            // uträkning
            change = paid - (int)Math.Round(total, MidpointRounding.AwayFromZero);
            subtotal = (uint)Math.Round(total);
            rounding = subtotal - total;



            //presentation
            Console.WriteLine("\nKVITTO");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(" {0,-20}  {1, 20:c}","Totalt: ", total);
            Console.WriteLine(" {0,-20}  {1, 20:c}","Öresavrundning: ", rounding);
            Console.WriteLine(" {0,-20}  {1, 20:c}","Att betala: ", total);
            Console.WriteLine(" {0,-20}  {1, 20:c}","Kontant:  ", paid);
            Console.WriteLine(" {0,-20}  {1, 20:c}","Tilbaka:  ", change);
            Console.WriteLine("----------------------------------------------");

            //int femhunda = 0;

            //femhunda = change / 500;
            //change = change % 500;


            if (change >= 500)
            {
                Console.WriteLine("500-lappar     : {0}", change / 500);
                change %= 500;
            }
            if (change >= 100)
            {
                Console.WriteLine("100-lappar     : {0}", change / 100); 
                change %= 100;
            }
            if (change >= 50)
            {
                Console.WriteLine("50-lappar      : {0}", change / 50); 
                change %= 50;
            }
            if (change >= 20)
            {
                Console.WriteLine("20-lappar      : {0}", change / 20); 
                change %= 20;
            }
            if (change >= 10)
            {
                Console.WriteLine("10-kronor      : {0}", change / 10);
                change %= 10;
            }
            if (change >= 5)
            {
                Console.WriteLine("5-kronor       : {0}", change / 5);
                change %= 5;
            }
            if (change >= 1)
            {
                Console.WriteLine("1-kronor       : {0}", change / 1);
                change %= 1;
            }

            
        }

      
    }
}
