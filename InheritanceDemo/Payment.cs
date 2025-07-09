using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class Payment
    {

        //private double _amount;

        //public double Amount
        //{
        //    get
        //    {
        //        return _amount;
        //    }
        //    set
        //    {
        //        _amount = value;
        //    }
        //}

        public double Amount { get; set; }
        public string TransactionId;

        public void EnterAmount()
        {
            Console.Write("Enter amount to pay: ");
            Amount = Convert.ToDouble(Console.ReadLine());

            TransactionId = Guid.NewGuid().ToString();
        }

        public virtual void Pay()
        {
            Console.WriteLine("Processing payment of ₹" + Amount);
        }


    }

    class CreditCard : Payment
    {
        public string CardNumber;

        public override void Pay()
        {
            Console.Write("Enter Credit Card Number: ");
            CardNumber = Console.ReadLine();

            Console.WriteLine($"Paid ₹{Amount} using Credit Card ending with {CardNumber.Substring(CardNumber.Length - 4)}.");
            Console.WriteLine($"Transaction ID: {TransactionId}");
        }

    }
}
