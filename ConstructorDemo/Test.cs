using System;

namespace ConstructorDemo
{

    //Before compilation
    class Test
    {
        public int i;
        public string s;
        public bool b;
        public char c;

        /*
         * 
         *  accessSpecifier Samename what u given to class()
         *  {
         *  }
         * 
         */

        public Test()
        {
            i = 25;
            s = "Dotnet";
            b = true;
            c = 'a';
            Console.WriteLine("Hi i am constructor");
        }

        public Test(int i, string s, bool b, char e)
        {
            this.i = i;
            this.s = s;
            this.b = b;
            c = e;
        }

        public void Greet()
        {
            Console.WriteLine("Hello I am Greet Method");
        }

    }

    //After compilation

}