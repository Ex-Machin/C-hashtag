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
            int [] luckyNumbers = { 4, 8, 34, 56, 1};
            string[] friends = new string[5];
            friends[0] = "Dima";
            friends[1] = "Artur";
            friends[2] = "Vlad";
            friends[3] = "Ksuisha";
            friends[4] = "Arsen";

            luckyNumbers[1] = 900;

            Console.WriteLine(luckyNumbers.Length);
        }
    }
}