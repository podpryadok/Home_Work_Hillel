using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Напишите программу, в которой метод будет вызываться рекурсивно.Каждый новый вызов метода выполняется в отдельном потоке.
namespace task_1
{
    class Program
    {
        static void Recursiv()
        {
            Console.WriteLine(Thread.CurrentThread.GetHashCode());
            Thread.Sleep(1000);
            new Thread(() => Recursiv()).Start();
        }

        static void Main(string[] args)
        {
            new Thread(() => Recursiv()).Start();
            Console.ReadLine();
        }
    }
}
