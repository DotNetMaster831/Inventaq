using AbstractionData;
using EcapsulationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SBI BANK");
            Bank sbi = BankFactory.GetBankObject("SBI");
            sbi.ValidateCard();
            sbi.CheckBalance();

            Console.WriteLine("ICICI BANK");
            Bank icici = BankFactory.GetBankObject("ICICI");
            icici.ValidateCard();
            icici.CheckBalance();
            Console.ReadKey();
        }


    }
}
