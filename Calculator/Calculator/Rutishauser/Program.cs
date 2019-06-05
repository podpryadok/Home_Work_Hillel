using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rutishauser
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Введите выражение: ");
                Console.WriteLine(Calculate.Calculated(Console.ReadLine()));
                Console.ReadLine();

        }
    }
}
