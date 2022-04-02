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
            bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a tall male");
            } else if(isMale && !isTall)
            {
                Console.WriteLine("You are a male but not tall");
            } else if(!isMale && isTall)
            {
                Console.WriteLine("You are tall but not male ");
            } else 
            {
                Console.WriteLine("You are not short woman \noh no...");
            }
        }
    }
}