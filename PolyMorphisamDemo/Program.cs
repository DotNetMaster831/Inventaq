using PolyMorphisamDemo.Ovveridng;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyMorphisamDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payement payement = new Payement();
            payement.Pay();


            CrediCard crediCard = new CrediCard();
            crediCard.Pay();
            Console.ReadKey();
        }
    }

    public class Employee
    {
        public void GetEmployeeInfo()
        {

        }

        public void GetEmployeeInfo(int id)
        {

        }

        public string GetEmployeeInfo(int id, int age)
        {
            return "Hello";
        }
    }

}
