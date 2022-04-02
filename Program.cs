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
            int num = Convert.ToInt32("45");
            Console.WriteLine(num + 5);


            Console.Write("Enter a number: ");
            double num1 =  Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number: ");
            double num2 =  Convert.ToDouble(Console.ReadLine());
               
             Console.WriteLine(num1 + num2);  
        }
    }
}