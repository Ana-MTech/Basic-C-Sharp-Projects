using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\C# and NET.Framework\test.txt";

            Console.WriteLine("Enter a number.");
            int userValue = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(userValue)


            using (var file = new StreamWriter(filePath, true))
            {

                file.WriteLine(userValue);
            }

            Console.ReadLine();
        }
    }
}
