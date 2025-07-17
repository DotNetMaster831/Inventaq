using System;
using MyOwnConsole;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //public --> any wher in the application u can use that data
            //Private --> Inside same class only u can use that
            //Protected -->
            //Internal --> 


            //BankUser user1 = new BankUser();
            //Console.WriteLine(user1.UserName);
            //Console.WriteLine(user1.AccountNumber);
            //Console.WriteLine(user1.AccountBalance);
            //Console.WriteLine(user1.BankBranch);
            //Console.WriteLine(user1.BankName);
            //Console.WriteLine(user1.LastWithdrawnAmmount);
            //Console.WriteLine(user1.LastDepositedAmmount);


            Console.WriteLine("Hello World");
            InputOutput.Print("Hello World");

        }
    }


    public class BankUser
    {
        public string UserName;
        public string AccountNumber;
        private string AccountBalance;
        public string BankName;
        public string BankBranch;
        private string LastDepositedAmmount;
        private string LastWithdrawnAmmount;

        public BankUser()
        {
            UserName = "Durga Sai";
            AccountNumber = "1234567890";
            AccountBalance = "2000000";
            BankName = "SBI";
            BankBranch = "Vizag";
            LastDepositedAmmount = "50000";
            LastWithdrawnAmmount = "10000";
        }

    }
}
