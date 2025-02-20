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
            string path = @"D:\data.txt";
            string path2 = @"D:\data1.txt";
            File.Copy(path, path2,true);
            

            Console.ReadLine();
        }
    }
}
