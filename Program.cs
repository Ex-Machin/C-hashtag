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
           int [,] numberGrid = {
                {1, 3},
                {3, 4},
                {4, 6}
           };
           int[,] myArray = new int[2,3];

           Console.WriteLine(numberGrid[1, 1]);
        }
    }
}