using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\user\Downloads\ISTQB\test.txt";
            string partOfText = string.Empty;
            Console.WriteLine("Put the word which you want to find");
            partOfText = Console.ReadLine();
            FindAndReplaceManager.FindNext(path, partOfText);

            Console.ReadLine();
        }
    }
}
