using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    interface IPerson
    {
        //properties
        //abstract methods
        //indexes
        //events

        void GetName();
        void GetGender();
        

    }

    public class Student :  IPerson
    {
        public void GetGender()
        {
            throw new NotImplementedException();
        }

        public void GetName()
        {
            throw new NotImplementedException();
        }
    }

}
