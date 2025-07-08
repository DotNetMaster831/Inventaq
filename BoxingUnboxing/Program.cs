using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Boxing --> process of converting value type data to refrence type data
             * UnBoxing --> Process of converting refrence data type to value data data type
             */

            int x = 10; //4gb

            object y = x; //Boxing //8gb 

            int z = (int)y; //Unboxing // 4gb

        }
    }
}
