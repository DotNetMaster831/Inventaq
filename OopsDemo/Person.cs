using System;

namespace OopsDemo
{
    class Person
    {
        //Proprties/State/Attributes/Fileds
        public string FirstName;
        public string LastName;
        public string FullName;
        public char Gender;
        public string Occupation;
        public int Age;
        public int Height;
        public int Weight;
        public string Education;

        //Behaviours/Operations/Methods
        public void DisplayPersonInfo()
        {
            Console.WriteLine("Person Details");
            Console.WriteLine($"First name is : {FirstName}");
            Console.WriteLine($"Second name is : {LastName}");
            Console.WriteLine($"Full name is : {FirstName} {LastName}");
            Console.WriteLine($"Gender is : {Gender}");
            Console.WriteLine($"Occupation is : {Occupation}");
            Console.WriteLine($"Age is : {Age}");
            Console.WriteLine($"Height is : {Height}");
            Console.WriteLine($"Weight is : {Weight}");
            Console.WriteLine($"Education is : {Education}");
        }

    }
}