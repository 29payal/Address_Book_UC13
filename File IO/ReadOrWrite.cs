using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    public class ReadOrWrite
    {
       // string path = @"C:\Users\DELL\Desktop\RFP\Address_Book_UC13\File IO\Demo.txt";
        public void Read(string path)
        {
            using (StreamReader sw = File.OpenText(path))
            {
                string line;
                while((line = sw.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }

            }
        }
        public void Write(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("FirstName   : Payal");
                sw.WriteLine("LastName    : Sharma");
                sw.WriteLine("Address     : 12 streets");
                sw.WriteLine("PhoneNumber : 9087865433");
                sw.WriteLine("City        : Nimuch");
                sw.WriteLine("State       : Madhya Pradesh");
                sw.WriteLine("Zip         : 458441");
                sw.WriteLine("Email       : abc@gmail.com"); 
                    sw.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
        }
    }
}
