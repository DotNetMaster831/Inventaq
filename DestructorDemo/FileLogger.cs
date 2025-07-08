using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    public class FileLogger : IDisposable
    {

        private StreamWriter _writer;

        public FileLogger(string filePath)
        {
            _writer = new StreamWriter(filePath);
            _writer.WriteLine("Log Started");
        }

        public void Dispose()
        {
            _writer.Close();
            Console.WriteLine("Writer colsed");
        }
    }
}
