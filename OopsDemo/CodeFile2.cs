using Details;
using System.Net;
using System;

namespace employee
{
    public class details
    {
        string FullName;
        int Age;
        string Gender;
        string Address;
        string PastOccupations;
        string Hobbies;
        string current_position;


        public void DisplayInfo()
        {
            Console.WriteLine($"Employee { FullName}");
            Console.WriteLine($"Employee { Age}");
            Console.WriteLine($"Employee { Gender}");
            Console.WriteLine($"Employee { Address}");
            Console.WriteLine($"Employee { PastOccupations}");
            Console.WriteLine($"Employee { Hobbies}");
            Console.WriteLine($"Employee { current_position}");
        }
    }
}

    