using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.Age = -5;
            ////s1.AssignValues();
            //Console.WriteLine(s1.Age);

            CoffeeMachine m1 = new CoffeeMachine(1000, 100);
            m1.MakeEspresso();
            Console.WriteLine($"Beans left: {m1.BeansLeft()} grams");

        }
    }


    public class Student
    {
        //private int age;



        //public int Age
        //{
        //    get
        //    {
        //        return age;
        //    }

        //    set
        //    {
        //        age = value;
        //    }
        //}

        public int Age { get; set; }


        public void AssignValues()
        {
            Age = 10;
        }

    }


}
