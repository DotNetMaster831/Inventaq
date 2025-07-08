using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class Example
    {
        int x; //non-static
        static int y = 200; //Static 

        public Example(int x)
        {
            this.x = x;
        }

        public static void Main()
        {
            //Accessing Static Variable using class name
            //Before Object Creation
            Console.WriteLine($"Static Variable Y = {Example.y}");


            //Accessing Static Variable using without class name
            //It’s possible because we are accessing the variable
            //from the same class
            Console.WriteLine($"Static Variable Y = {y}");



            Example obj1 = new Example(50);
            Console.WriteLine($"Static Variable Y = {obj1.x}");




        }

        public void GetMeassge()
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
    }
}
