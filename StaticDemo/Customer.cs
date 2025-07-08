using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class Customer
    {
        public string Name;
        public string PhoneNumber;
        private string MachineName;


        public Customer()
        {
            
            MachineName = CommonTask.GetMachineName();
        }



        public void InserToDb()
        {
            if (!CommonTask.IsEmpty(Name) && !CommonTask.IsEmpty(PhoneNumber))
            {
                //It will insert
            }
        }

    }
}
