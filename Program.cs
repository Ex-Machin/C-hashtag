using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe 
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "Yale";
            string quess = "";
            int quessCount = 0;
            int quessLimit = 3;
            bool outOfQuesses = false;

            do
            {
                if (quessCount < quessLimit) 
                {
                    Console.Write("Enter quess: ");
                    quess = Console.ReadLine();
                    quessCount++;
                } else 
                {
                    outOfQuesses = true;
                }
            } while(quess != secretWord && !outOfQuesses);

            if(!outOfQuesses) 
            {
                Console.WriteLine("You Win!");
            } else 
            {
                Console.WriteLine("You Lose!");
            }
        }
    }
}