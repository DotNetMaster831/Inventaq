using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class RunTimeCasting
    {
        public static void GetRunTimeCasting()
        {
            string numberString = "123";
            string invalidString = "abc";

            ////Prase
            //int num1 = int.Parse(numberString); //works fine
            //Console.WriteLine("Using Parse: " + num1);

            //int num2 = int.Parse(invalidString);


            ////Try Prase
            //bool success = int.TryParse(numberString, out int num3);
            //if (success)
            //{
            //    Console.WriteLine("Using TryParse (valid): " + num3);
            //}
            //else
            //{
            //    Console.WriteLine("Using TryParse (valid): Conversion failed");
            //}

            //bool success1 = int.TryParse(invalidString, out int num4);
            //if (success1)
            //{
            //    Console.WriteLine("Using TryParse (valid): " + num3);
            //}
            //else
            //{
            //    Console.WriteLine("Using TryParse (valid): Conversion failed");
            //}


            int num5 = Convert.ToInt32(numberString);
            Console.WriteLine("Using Convert (valid): " + num5);

            int num6 = Convert.ToInt32(invalidString);
            Console.WriteLine("Using Convert (valid): " + num6);

            /*
             * 📌 Console Practice
                1️⃣ Read two numbers from console, add them and display the sum.

                2️⃣ Ask user to enter their name and display:

                "Hello, [Name]! Welcome to C# world."

                3️⃣ Read age from user and display in next line:

                "You will be [age + 5] years old after 5 years."



            📌 Data Types Practice
                4️⃣ Declare variables of all basic data types (int, float, double, char, bool, string) and print them.

                5️⃣ Declare a constant value for PI and calculate area of circle after reading radius from user.

                6️⃣ Show example of overflow by assigning a value larger than byte can hold.
                    byte b = 300; // What happens? Try and see.

                7️⃣ Use var keyword to declare variables and print their types using GetType().


            📌 Type Casting Practice
                8️⃣ Read a decimal number (e.g. float or double) from user, cast it to integer and display both values.

                9️⃣ Demonstrate implicit casting by assigning int to double.

                10️⃣ Demonstrate explicit casting by converting double to int and explain data loss.

                11️⃣ Demonstrate data loss when casting large int to byte.
             */
        }
    }
}
