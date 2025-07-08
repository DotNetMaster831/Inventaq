using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesOfVariables
{
    internal class Program
    {
        const float piVal = 3.141f;
        readonly float piVal3;

        public Program()
        {
            piVal3 = piVal;
        }

        static void Main(string[] args)
        {
            //1. constant
            //2. readonly

            int a = 25;
            a = 36;
            a = 89;

            float pi = 3.141f;
            pi = 89.56f;

            const float piVal2 = 3.141f;
            //piVal = 56.45f;

            //1. we should use const keyword
            //2. constants are by default static
            //3. It is mandatory to intialize constant varaible at the time of declartion


            //Readonly;

            const int b = 25;

            Console.WriteLine(piVal);
            Program program = new Program();
            Console.WriteLine(program.piVal3);
            

        }
    }
}
