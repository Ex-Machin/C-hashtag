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
            Console.WriteLine(GetDay(4));
        }
        static string GetDay(int dayNum) 
        {
            string dayName = "0";

            switch (dayNum) 
            {
                case 0:
                    dayName = "Sunday";
                    break;        
                case 1: 
                    dayName = "Monday";
                    break;
                case 2: 
                    dayName = "Tuesday";
                    break;
                case 3: 
                    dayName = "Wednesday";
                    break;
                case 4: 
                    dayName = "Thursday";
                    break;
                case 5: 
                    dayName = "Friday";
                    break;
                case 6: 
                    dayName = "Saturda";
                    break;
                default:
                    Console.WriteLine("Wrong value");
                  break;

            }

            return dayName;
        }
    }
}