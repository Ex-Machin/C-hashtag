using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hwapp 
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie avengers = new Movie("The Avangers", "Joss Whedon", "Dog");
            Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");

            Console.WriteLine(avengers.Rating);
        }
    }
}