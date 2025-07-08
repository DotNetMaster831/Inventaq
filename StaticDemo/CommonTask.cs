using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDemo
{
    public class CommonTask
    {

        //public int i = 0;
        //public static int j =0;

        public static bool IsEmpty(string str)
        {
            if (str != null || str != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string GetMachineName()
        {
            return System.Environment.MachineName;
        }

        public void Greet()
        {

        }


        public void LetsTalk()
        {

        }

    }
}
