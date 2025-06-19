using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    public class TypeCastingExample
    {
        public static void GetMessage()
        {
            //Implicit
            int smallNumber = 10;
            double bigNumber = smallNumber;

            Console.WriteLine("Implicit Casting:");
            Console.WriteLine("int value: " + smallNumber);
            Console.WriteLine("double value (after implicit cast): " + bigNumber);
            Console.WriteLine();

            //Explicit
            double price = 99.99;
            int roundedPrice = (int)price;

            Console.WriteLine("Explicit Casting:");
            Console.WriteLine("double value: " + price);
            Console.WriteLine("int value (after explicit cast): " + roundedPrice);
            Console.WriteLine();

            //Posible Data Loss
            int bigInt = 300;
            byte smallByte = (byte)bigInt;

            Console.WriteLine("Data Loss Example:");
            Console.WriteLine("Original int value: " + bigInt);
            Console.WriteLine("After casting to byte: " + smallByte);
        }
    }
}
