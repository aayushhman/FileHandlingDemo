using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\data.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("this file is found..");
            }
            else
            {
                Console.WriteLine("This fiole is not found..");
            }
            Console.ReadLine();
        }
    }
}
