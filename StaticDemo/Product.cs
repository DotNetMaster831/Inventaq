using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    internal class Product
    {
        public string Name;
        public string Description;

        public string MachineName = System.Environment.MachineName;


        public Product()
        {
            MachineName = CommonTask.GetMachineName();
        }


        public void InserToDb()
        {

            
            //Inser operation
            if(CommonTask.IsEmpty(Name) && CommonTask.IsEmpty(Description))
            {

            }
        }



    }
}
