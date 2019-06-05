using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Leha", 2008, "QA");
            Worker worker2 = new Worker("Chel", 2009, "Dev");
            Worker worker3 = new Worker("Paladin Mraka", 2000, "PM");
            Worker worker4 = new Worker("Alex", 2010, "Desiner");

            Workers workers = new Workers();

            workers.GetWorkers(worker1);
            workers.GetWorkers(worker2);
            workers.GetWorkers(worker3);
            workers.GetWorkers(worker4);

            workers.Print(2001);
            Console.WriteLine("-");
            workers.Print(true);
            Console.ReadLine();
        }
    }
}
