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

            SayHi("Sara", 23);
        }

        static void SayHi(string name, int age) 
        {
            Console.WriteLine("Hello " + name + " you are " + age);
        }
    }
}