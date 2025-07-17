using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //What is Exception
            int a = 10;
            int b = 0;

            int c;
            try
            {
                try
                {
                    try
                    {

                    }
                    catch
                    {

                    }
                }
                catch
                {

                }
                c = a / b;
                Console.WriteLine("C VALUE = " + c);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            //finally
            //{
            //    b = 5;
            //    c = a / b;
            //    Console.WriteLine("C VALUE = " + c);
            //}
            Console.WriteLine("A VALUE = " + a);
            Console.WriteLine("B VALUE = " + b);



            Console.ReadKey();
        }
    }
}
