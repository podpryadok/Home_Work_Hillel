using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте анонимный метод,
//который принимает в качестве параметров три целочисленных аргумента и возвращает среднее арифметическое этих аргументов.
namespace Task_1
{
    class Program
    {
        delegate double MidlArf(int a, int b, int c);

        static void Main(string[] args)
        {
            MidlArf midlArf = delegate (int a, int b, int c)
            {
                double mid = (a + b + c) / 3;
                return mid;
            };
            
            Console.WriteLine(midlArf.Invoke(5, 10, 15));
            Console.ReadLine();
        }
    }
}
