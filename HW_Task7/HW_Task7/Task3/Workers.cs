using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Построить три класса(базовый и 2 потомка), описывающих некоторых работников с почасовой оплатой(один из потомков) 
//и фиксированной оплатой(второй потомок). 
//а) Описать в базовом классе абстрактный метод для расчета среднемесячной заработной платы.
//Для «повременщиков» формула для расчета такова: «среднемесячная заработная плата = 20.8 * почасовую ставку»,
//для работников с фиксированной оплатой «среднемесячная заработная плата = фиксированной месячной оплате». 
//б) Создать на базе абстрактного класса массив сотрудников и заполнить его.
//в) Реализовать интерфейсы для возможности сортировки массива используя Array.Sort(). 
//г) Реализовать возможность вывода данных с использованием foreach
namespace Task3
{
    interface IWorkerSort
    {
        void TypeSort(ref List<Workers> workers);
        void SalarySort(ref List<Workers> workers);
    }

    abstract class Workers
    {
        private string typeSalary;
        private double salary;
        public double aMSalary;

        public string TypeSalary { get => typeSalary; }
        public double Salary { get => salary; }

        public Workers(double salary, string typeSalary)
        {
            this.salary = salary;
            this.typeSalary = typeSalary;
        }

        public abstract void AverageMonthlySalary();
        
        //Not working Sort((
        //public void SalarySort(ref List<Workers> workers)
        //{
        //    double[] workersArray = new double[workers.Count];
        //    foreach (var w in workers)
        //    {
        //        for(int i = 0; i > workersArray.Length; i++)
        //        {
        //            workersArray[i] = w.salary;
        //        }
        //    }
        //    for (int i = 1; i < workersArray.Length; i++)
        //    {
        //        int j = 0;
        //        double buffer = workersArray[i];
        //        for (j = i - 1; j >= 0; j--)
        //        {
        //            if (workersArray[j] < buffer)
        //                break;
        //            workersArray[j + 1] = workersArray[j];
        //        }
        //        workersArray[j + 1] = buffer;
        //    }
        //}

        //public void TypeSort(ref List<Workers> workers)
        //{
        //    workers.Sort();
        //}
    }

    class WorkerFixPay : Workers
    {
        public WorkerFixPay(double salary, string typeSalary)
            : base(salary, typeSalary)
        {
        }

        public override void AverageMonthlySalary()
        {
            aMSalary = base.Salary;
        }
    }

    class WorkerHourPay : Workers
    {
        public WorkerHourPay(double salary, string typeSalary)
            : base(salary, typeSalary)
        {
        }

        public override void AverageMonthlySalary()
        {
            aMSalary = 20.8 * base.Salary;
        }
    }
}
