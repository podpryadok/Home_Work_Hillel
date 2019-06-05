using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Workers
    {
        private List<Worker> workers;
        private List<Worker> temp;

        public Workers()
        {
            workers = new List<Worker>();
            temp = new List<Worker>();
        }

        public void GetWorkers(Worker worker)
        {
            workers.Add(worker);
        }

        public void Print(double userAmount)
        {
            foreach (var worker in workers)
            {
                if (userAmount <= worker.StartYear)
                {
                    Show(worker);
                }
            }
        }

        public void Print(bool isSorted)
        {
            if (isSorted)
                temp = workers.OrderBy(x => x.FullName).ToList();

            foreach (var tm in temp)
            {
                Show(tm);
            }
        }

        public void Show(Worker worker)
        {
            Console.WriteLine($"{worker.FullName}->{worker.Job}->{worker.StartYear}");
        }

    }
}
