using System;

namespace Operators
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * Operator : It is responsible to do some operations on data
             * 1. Arthametic Operator --> +, -, /, *, %
             * 2. Comaprison Operator --> ==, !=, <, <=, >, >=
             * 3. Logical Operators --> &&(AND), ||(OR), !(NOT)
             * 4. Assignement Operators--> =, +=, -=, *=, /=
             * 5. Unary Operators --> ++, --
             * 6. Ternary Operators --> ?,
             */


            ////Arthametic
            //int a = 25;
            //int b  = 50;

            //Console.WriteLine(a + b); // 13
            //Console.WriteLine(a - b); // 7
            //Console.WriteLine(a * b); // 30
            //Console.WriteLine(a / b); // 3
            //Console.WriteLine(a % b); // 1 (modulus = remainder)

            //Console.WriteLine("Compariso:");

            //int age = 18;
            //Console.WriteLine(age >= 18);
            //Console.WriteLine(age == 18);
            //Console.WriteLine(age != 20);

            //Console.WriteLine("Logical:");

            //bool isStudent = true;
            //bool hasIdCard = true;

            //Console.WriteLine(isStudent && hasIdCard);
            //Console.WriteLine(isStudent || hasIdCard);
            //Console.WriteLine(!isStudent);

            //Console.WriteLine("Assignement");

            //int num1 = 50;
            //Console.WriteLine(num1);
            ////num1 /= 20;
            ////Console.WriteLine(num1);

            //num1++;
            //Console.WriteLine(num1);


            //Conditions -->If else
            //Loops --> for, while, do while, foreach
            //Jumping Statement --> break, continue, return


            //If else syntax
            /*
             * if(condition){
             *  Console.WriteLine("Please collect the cash")
             * }
             * else{
             *  Console.WriteLine("Insufficient Blanace")
             * }
             */

            int balance = 1500;
            int withdraw = 2000;

            if(balance >= withdraw)
            {
                Console.WriteLine("Withdrawal successful");
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

            //Nested If-else

            int marks = 85;
            if(marks >= 90)
            {
                Console.WriteLine("Grade A");
            }
            else if(marks >= 80)
            {
                Console.WriteLine("Grade B");
            }
            else if(marks >= 75)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D");
            }

            if (marks >= 90)
            {
                Console.WriteLine("Grade A");
            }
            if (marks >= 80)
            {
                Console.WriteLine("Grade B");
            }
            if (marks >= 75)
            {
                Console.WriteLine("Grade C");
            }
            else
            {
                Console.WriteLine("Grade D");
            }



            //Loops
            //Syntax
            //  for(initilization; condition; increment/decrement){
            //  }
            //  

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i}. Grade D");
            //}

            //int gg = 25;
            //Console.WriteLine("the value is : gg");
            //Console.WriteLine($"The value is {gg}");

            //Interpolation
            //Synatx --> $"Hi {data}"


            //While
            //Syntax --> While(Condition){
            //}


            //int i = 1;
            //while(i <= 5)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            ////Do While
            ////Synatx do{
            ////}while()


            //string input;
            //do
            //{
            //    Console.WriteLine("Enter exit to stop:");
            //    input = Console.ReadLine();
            //} while (input != "exit");


            for(int i = 1; i <= 10; i++)
            {
                if(i == 3)
                {
                    continue;
                }
                if(i == 8)
                {
                    break;
                }
                Practice.GetEvenNumber(i);
            }




            Console.ReadKey();
        }
    }
}