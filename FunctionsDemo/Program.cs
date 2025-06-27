using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FunctionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Functions or Methods
            //A function is a block of code designed to perform specific task


            //int a = 1;
            //int b = 2;
            //int c = a + b;
            //Console.WriteLine(c);


            //int d = 3;
            //int e = 4;
            //int f = d+e;
            //Console.WriteLine(f);



            //int g = 5;
            //int h = 6;
            //int i = g + h;
            //Console.WriteLine(i);


            //GetSum(1, 2);
            //GetSum(3, 4);
            //GetSum(5, 6);



            //syantax
            /*
             * returnType nameofthefunction(parameters)
             * {
             * 
             * }
             */

            //Types
            //1. Parametersless methods
            //2. Parameters methods

            //Greet();
            //Greet2("Swaroop");
            //Greet3("Arjun", 22);
            //int year = Greet4("Arjun", 22);
            //Console.WriteLine(year);


            Console.ReadKey();

        }

        //public static void GetSum(int a, int b)
        //{
        //    Console.WriteLine(a+b);
        //}


        /// <summary>
        /// Parametersless Method or function
        /// </summary>
        public static void Greet()
        {
            Console.WriteLine("Hello Good morning");
        }


        public static void Greet2(string name)
        {
            Console.WriteLine($"Hello Good morning {name}");
        }

        public static void Greet3(string name, int age)
        {
            Console.WriteLine($"Hello Good morning {name} your age is {age}");
        }


        public static string Greet4(string name, int age)
        {
            Console.WriteLine($"Hello Good morning {name} your age is {age}");

            int yearofBirt = 2025 - age;

            return "Durga";

            int a = 20;

        }


        // 5!---> 5*4! --> 5*4*3!

        static int GetFactorial(int num)
        {
            return num * GetFactorial(num - 1);
        }
    }
}
