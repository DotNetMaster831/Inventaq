using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorDemo
{
    internal class StartArea
    {

        public StartArea()
        {

        }


        static void Main(string[] args)
        {


            
            

            Test t1 = new Test(25, "Dotnet", true, 's');
            //t1.i = 25;
            //t1.s = "Dotnet";
            //t1.c = 'c';
            //t1.b = true;

            Test t2 = new Test(35, "c#", true, 'g');
            //t2.i = 35;
            //t2.s = "c#";
            //t2.c = 'd';
            //t2.b = true;

            //Test t3 = new Test();
            //t3.i = 56;
            //t3.s = "Dotnet";
            //t3.c = 'c';
            //t3.b = true;

            //Test t4 = new Test();
            //t4.i = 89;
            //t4.s = "jhdfgh";
            //t4.c = 'c';
            //t4.b = true;

            Console.WriteLine(t1.i);
            Console.WriteLine(t1.s);
            Console.WriteLine(t1.b);
            Console.WriteLine(t1.c);

            Console.WriteLine(t2.i);
            Console.WriteLine(t2.s);
            Console.WriteLine(t2.b);
            Console.WriteLine(t2.c);

            //Console.WriteLine(t3.i);
            //Console.WriteLine(t3.s);
            //Console.WriteLine(t3.b);
            //Console.WriteLine(t3.c);

            //Console.WriteLine(t4.i);
            //Console.WriteLine(t4.s);
            //Console.WriteLine(t4.b);
            //Console.WriteLine(t4.c);


            //Type of Constructor
            //1. Default 
            //2. parameterized constructor
            //3. copy
            //4. static
            //5. private 

            Test t5 = new Test();

        }
    }
}
