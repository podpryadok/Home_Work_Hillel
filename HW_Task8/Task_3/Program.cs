using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 1, 4, 23, 132, 235, 2, 3, 8, 10, 9 };
            array.SortArrayToUp();
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
