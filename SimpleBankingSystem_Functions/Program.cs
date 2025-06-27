using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankingSystem_Functions
{
    internal class Program
    {

        static string customerName;
        static double balance = 20000;


        static void Main(string[] args)
        {

            Console.WriteLine(args[0]);
            Console.WriteLine(args[1]);
            Console.WriteLine(args[2]);


            int a = 25;

            CreateAccount();

            Deposit(5000);

            Withdraw(2000);

            double balance = GetBalance();
            Console.WriteLine("Balance is "+balance);


            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Hi");
            }



            // 5! --> 5*4*3*2*1
            // 100! --> 100*99*98*97*96*95............1

        }




        static void CreateAccount()
        {
            CreateAccount();

            string name;


            Console.WriteLine("Enter Customer Name: ");
            customerName = Console.ReadLine();

            Console.WriteLine("Account created for "+ customerName);

        }

        static void Deposit(double amount)
        {
            

            balance = balance + amount;

            double bl = GetBalance();

            Console.WriteLine($"{amount} is desposited successfully now you have {bl} in your account");
        }

        static void Withdraw(double amount)
        {
            
            balance = balance - amount;
            Console.WriteLine($"{amount} is Withdrawn successfully");
        }

        static double GetBalance()
        {
            return balance;
        }

    }


}
