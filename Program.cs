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
            string phrase = "Giraffe \nAcademy";
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.IndexOf("Z"));
            Console.WriteLine(phrase.Substring(8, 3));
        }
    }
}