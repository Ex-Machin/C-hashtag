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
            Console.WriteLine(Math.Sqrt(144));
            // Здесь нам не нужно создавать instance для Math - класса 
            // Так как у него есть static метод 
            UsefulTools.SayHi("Dima");
        }
    }
}