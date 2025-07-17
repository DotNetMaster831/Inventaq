using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;

            // 1,2,3,4,5,6
            //Array --> Its fixed size collection of same type elements

            //Syantx
            //datatype[] nameofArray = new datatype[size]

            //numbers 1 t0 100;
            int[] numbers = new int[100];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[99] = 100;

            int[,] matrix1 = new int[2, 3]
            {
                {1,2, 3},
                {2, 3, 4},
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix1[i, j] + " ");
                }
                Console.WriteLine();
            }


            //int[] number1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //for(int i = 0;i < number1.Length; i++)
            //{
            //    Console.WriteLine(number1[i]);
            //}


            //string[] names = { "durga", "arjun", "swaroop", "Ayman" };

            


            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            //foreach(string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            ////Collections
            ////1. non generic 1.ArrayList
            ////2. generic 1. List

            //ArrayList data = new ArrayList();
            //data.Add("durga");
            //data.Add(1);
            //data.Add(true);

            //foreach(string name in data)
            //{
            //    Console.WriteLine(name);
            //}

            //data.Add("arjun");

            ////Generic
            ////u are not allowed to add diffrent data types. but there is no fixed size

            //List<int> nums = new List<int>();
            //List<string> strings = new List<string>()
            //{
            //    "durg",
            //    "sai",
            //};

            //foreach(int val in nums)
            //{

            //}

            ////dictionary

            //Dictionary<int, string> students = new Dictionary<int, string>()
            //{
            //    { 1,"Durga" },
            //    { 2,"arjun" }
            //};

            //foreach(var student in students)
            //{
            //    Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            //}


        }
    }
}
