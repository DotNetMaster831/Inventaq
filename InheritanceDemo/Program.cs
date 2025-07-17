using System;
using EcapsulationData;

namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //Staff st1 = new Staff();
            
            B obj = new B();
            obj.Method1();
            obj.Method2();
            obj.Method3();

            A obj2 = new A();
            obj2.Method2();
            obj2.Method1();

            //Single inheritance
            //Multi level
            //Hierarchical Inheritance
            //Multiple Inheritance

            Console.WriteLine();

            SBI obj3 = new SBI();
            


        }
    }


    class A
    {
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }

        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }

    class B : A
    {
        //public void Method1()
        //{
        //    Console.WriteLine("Method 1");
        //}

        //public void Method2()
        //{
        //    Console.WriteLine("Method 2");
        //}
        public void Method3()
        {
            Console.WriteLine("Method 3");
        }
    }

     class C : B
    {

    }

    class D : B
    {

    }

    class E : B
    {

    }

    class F : D, E
    {

    }

    //class F : E
    //{

    //}

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }



    public class Student : Person
    {

        public string Class { get; set; }
        public string Marks { get; set; }
        public string Fees { get; set; }

    }

    public class  Staff : Person
    {
        public string Designation { get; set; }
        public string Salary { get; set; }
    }

    public class TeachingStaff : Staff
    {

        public string Qualification { get; set; }
        public string Subject { get; set; }

    }

    public class NonTeachingStaff : Staff
    {
        public string DeptName { get; set; }
        public string ManagerId { get; set; }
    }
}
