using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClassDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee
            {
                FirstName = "Dotnet",
                LastName = "Tutorials",
                Salary = 10000,
                Gender = "Male"
            };

            emp.DisplayFullName();
            emp.DisplayEmployeeDetails();
            Console.ReadKey();
        }
    }
}
