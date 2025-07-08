//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OopsDemo
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {

//            //Value type data types
//            //int char, float, decimal


//            //Refrence type
//            //string, object

//            int a = 25;

//            string str1 = "dotnet";




//            /*
//             * 1. class
//             * 2. object
//             * 3. Inheritance
//             * 4. Polymorphisam
//             * 5. Ecapsulation
//             * 6. Abstraction
//             * 
//             * 
//             * 
//             * class: Class is a blue print. Or class is a user defined refrence data type. (car drawing)
//             * object: it is instance of a class. (bmw, creta, nexon)
//             * 
//             */





//        }
//    }
//}


using System;

namespace OopsDemo
{
    class Program
    {
        public static void Main(string[] args)
        {

            


            Person p1;
            p1 = new Person();

            Console.WriteLine(p1.GetType());
            p1.FirstName = "Arjun";
            p1.LastName = "Kumar";
            p1.Gender = 'M';
            p1.Occupation = "Student";
            p1.Age = 22;
            p1.Height = 5;
            p1.Weight = 50;
            p1.Education = "Btech";

            p1.DisplayPersonInfo();


            Console.WriteLine();

            Person p2 = new Person();
            Console.WriteLine(p2.ToString());
            p2.FirstName = "Ayman";
            p2.LastName = "Shaik";
            p2.Gender = 'M';
            p2.Occupation = "Software Engioneer";
            p2.Age = 25;
            p2.Height = 6;
            p2.Weight = 60;
            p2.Education = "Btech";


            p2.FirstName = "Arjun";
             
            p2.DisplayPersonInfo();

        }
    }
}