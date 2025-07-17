using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface ITestInterface1
    {
        void Add(int num1, int num2);
    }

    interface ITestInterface2 : ITestInterface1 // 2 methods
    {
        void Sub(int num1, int num2);
    }
    public class ImplementationClass1 : ITestInterface1
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
    }

    public class ImplementationClass2 : ITestInterface2
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }

        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Sub of {num1} and {num2} is {num1 - num2}");
        }
    }

    public class ImplementationClass3 : ITestInterface1, ITestInterface2
    {
        public void Add(int num1, int num2)
        {
            throw new NotImplementedException();
        }

        public void Sub(int num1, int num2)
        {
            throw new NotImplementedException();
        }
    }

    public class ggggg : ImplementationClass1, ITestInterface1
    {

    }

    //allowed
    interface IA
    {

    }

    interface IB
    {

    }

    public class Parent
    {

    }

    public class Children : Parent, IA
    {

    }

    //allowed
    public class children3 : IA, IB
    {

    }

    //not allowed
    public class Parent2
    {

    }

    //public class Children2 : Parent, Parent2
    //{

    //}
}
