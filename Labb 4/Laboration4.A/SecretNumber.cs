using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboration4.A
{
    public class SecretNumber
    {

        int _count = 0;
        int _number;

        public const int MaxNumberOfGuesses = 7;

        public SecretNumber()
        {
            Initialize();
        }
        
        public void Initialize()
        {
            _count = 0;
            Random RandomNumber = new Random();
            _number = RandomNumber.Next(1, 101);
        }       

        public bool MakeGuess(int number)
        {

            if (_count >= 7)
            {
                throw new ApplicationException();
            }

            int _guesses = MaxNumberOfGuesses - _count - 1;
           
            _count++;

            if (number < 1 || number > 100)
            {
                throw new ArgumentOutOfRangeException();
            }  

            if (number == _number)
            {
                Console.WriteLine("{0} Grattis du klarade det på {1} försök", number, _count);
                return true;
            }

            else if (number > _number)
            {
                Console.WriteLine("{0} Ditt tal är för högt, försök igen! Försök kvar {1}", number, _guesses);
            }

            else 
            {
                Console.WriteLine("{0} Ditt tal är för lågt försök igen! Försök kvar {1}", number, _guesses);
            }
            
           if (MaxNumberOfGuesses == _count)
           {
               Console.WriteLine("Det hemliga talet är {0}", _number);
           }
           return false;

        }
    }
}
