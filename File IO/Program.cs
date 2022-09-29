using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReadOrWrite readOrWrite = new ReadOrWrite();
            string path = @"C:\Users\DELL\Desktop\RFP\Address_Book_UC13\File IO\Demo.txt";
            readOrWrite.Read(path);
            readOrWrite.Write(path);
            Console.ReadLine();

        }
    }
}
