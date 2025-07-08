using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Destructor
            //It is special method it called automatically
            //when object is no longer needed.

            FileLogger f1 = new FileLogger(@"C:\DurgaSai\Classes\Inventaq\DestructorDemo\data.txt");
            f1.Dispose();

            //Garbage Collector --> feature in clr clears unused managed objects

            //Managed code --> Whatever you will write with .net supported langauge
            // in visual studio that is identified by CLR is called managed code.

            //Unmanaged code --> 

            //Finalise()


        }
    }

    public class FileWriter
    {
        private StreamWriter _writer;

        public FileWriter()
        {
            _writer = new StreamWriter(@"C:\DurgaSai\Classes\Inventaq\DestructorDemo\data.txt");
            // C:\DurgaSai\Classes\Inventaq\DestructorDemo\data.txt
            _writer.WriteLine("Writing some data...");
            Console.WriteLine("File opend and data written");

        }


        ~FileWriter()
        {
            //_writer.Close();
            Console.WriteLine("FileWriter destructor called: File Closed.");
        }
    }

}
