using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Построить три класса(базовый и 2 потомка), описывающих некоторых работников с почасовой оплатой(один из потомков) 
//и фиксированной оплатой(второй потомок). 
//а) Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы.
//Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата = 20.8 8 почасовую ставку»,
//для работников с фиксированной оплатой «среднемесячная заработная плата = фиксированной месячной оплате». 
//б) Создать на базе абстрактного класса массив сотрудников и заполнить его.
//в) Реализовать интерфейсы для возможности сортировки массива используя Array.Sort(). 
//г) Реализовать возможность вывода данных с использованием foreach
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Workers> workers = new List<Workers>();

            WorkerFixPay workerFixPay1 = new WorkerFixPay(2000, "Fix");
            WorkerFixPay workerFixPay2 = new WorkerFixPay(3000, "Fix");            
            WorkerHourPay workerHourPay1 = new WorkerHourPay(50, "HourPay");
            workers.Add(workerFixPay2);
            workers.Add(workerHourPay1);
            workers.Add(workerFixPay1);

            workerHourPay1.AverageMonthlySalary();
            workerFixPay2.AverageMonthlySalary();
            workerFixPay1.AverageMonthlySalary();

            foreach (var w in workers)
            {
                Console.WriteLine($"Тип оплаты: {w.TypeSalary}; Зарплата: {w.Salary}; Средняя зарплата в месяц: {w.aMSalary}");
            }
            Console.WriteLine(new string ('_',40));

            //workerFixPay1.SalarySort(ref workers);

            //foreach (var w in workers)
            //{
            //    Console.WriteLine($"Тип оплаты: {w.TypeSalary}; Зарплата: {w.Salary}; Средняя зарплата в месяц: {w.aMSalary}");
            //}

            Console.ReadLine();
        }
    }
}
