using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    internal class Practice
    {
        public static void GetEvenNumber(int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine($"{num} is Even Number");
            }
            else
            {
                Console.WriteLine($"{num} is Odd Number");
            }
        }
    }
}
