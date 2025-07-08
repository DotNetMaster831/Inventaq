using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Strings

            //string name = "Dotnet";
            //object obj = null;

            decimal d = 53.6963m;

            string name = "Dotnet";
            name = "Tutorial";
            

            //Mutable
            //Imutable



            //StringBuilder sb = new StringBuilder();
            //sb.Append(name);

            //Console.WriteLine(sb.ToString());



            //String Operations


            //1. String Concatenation

            string firstName = "Dotnet";
            string lastName = "Tutorials";

            //DotnetTutorials

            string fullName = firstName + lastName + "Classes";

            Console.WriteLine("sum is " + 2+3);

            int count = fullName.Length;

            //upper case and lower case

            string upper = firstName.ToUpper();

            string lower = firstName.ToLower();


            string msg = "##Hello  ##";

            Console.WriteLine(msg);
            //Console.WriteLine(msg.Trim('#'));
            Console.WriteLine(msg.TrimStart('#'));
            Console.WriteLine(msg.TrimEnd('#'));

            string featureName = " ";
            string featureName2 = "Kitchen product items";
            string featureName3 = "Garden product items";

            if (featureName.Contains("Kitchen")){
                Console.WriteLine(featureName);
            }

            if (featureName.StartsWith("items"))
            {
                Console.WriteLine(featureName);
            }


            //string replacedFeature = featureName.Replace("product", "Equipments");

            //string part1 = featureName.Substring(11,7);

            int index = featureName.IndexOf('p');

            int result = string.Compare(featureName, "Electronic product items");

            if(featureName.Equals("Electronic product items"))
            {
                Console.WriteLine(featureName);
            }

            bool check1 = string.IsNullOrEmpty(featureName);
            bool check2 = string.IsNullOrWhiteSpace(featureName);

        }
    }
}
