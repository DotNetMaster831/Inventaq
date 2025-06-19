using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Integers
            //strings
            //char

            //int
            //flaot
            //short
            //ushort
            //long
            //double
            //decimal
            //byte


            //implicit type casting
            //explicit type casting

            //implicit
            int a = 25;
            float c = a;

            //explicit
            float d = 2.5678993f;
            int e = (int) d;

            double f = 56;
            float g = (float)f;

            Console.WriteLine("a: "+a);
            Console.WriteLine("c: "+c);
            Console.WriteLine("d: "+d);
            Console.WriteLine("e: "+e);

            //Convert
            //Parse
            //TryParse

            //double num1 = Convert.ToDouble(Console.ReadLine());


            //////Parse
            //string num2 = Console.ReadLine();

            //float gg;



            //bool isCorrectValue = float.TryParse(num2, out gg);

            ////var b = Console.ReadLine();
            ///

            //TypeCastingExample.GetMessage();

            RunTimeCasting.GetRunTimeCasting();

            Console.ReadKey();

        }
    }
}
