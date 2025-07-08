using Details;
using System.Data;
using System;

namespace Details
{
    public class Employee
    {
        public string Firstname;
        public string Lastname;
        public string Fullname;
        public string Education;
        public string role;
        public int age;


        public void DisplayInfo()
        {
            Console.WriteLine($"Employee name{Firstname}");

            Console.WriteLine($"Employee {Lastname}");

            Console.WriteLine($"Employee {Fullname}");

            Console.WriteLine($"Employee education{Education}");

            Console.WriteLine($"Employee role{role}");

            Console.WriteLine($"Employee age {age}");


        }
    }

    class Info
    {
        public static void main(string[] args)
        {
            Employee a1;
            a1 = new Employee();

            a1.Firstname = "arjun";
            a1.Lastname = "kumar";
            a1.Fullname = "arjun kumar";
            a1.Education = "BECSE";
            a1.role = ".Net Developer";
            a1.age = 21;
            a1.DisplayInfo();
        }
    }
}

