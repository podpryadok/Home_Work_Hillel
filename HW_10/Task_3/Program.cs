using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте анонимный метод, 
//который принимает в качестве аргумента массив делегатов и возвращает среднее арифметическое 
//возвращаемых значений методов сообщенных с делегатами в массиве.
//Методы, сообщенные с делегатами из массива, возвращают случайное значение типа int.
namespace Task_3
{
    delegate double Muth(Delegate a, Delegate b, Delegate c);
    delegate double MuthA(double a, double b, double c);
    delegate double MuthB(double a, double b, double c);
    delegate double MuthC(double a, double b, double c);

    class Program
    {
        static void Main(string[] args)
        {
            MuthA muthA = delegate (double a, double b, double c)
            {
                double mid = (a + b + c) / 3;
                return mid;
            };

            MuthA muthB = delegate (double a, double b, double c)
            {
                double mid = (a + b + c) / 3;
                return mid;
            };

            MuthA muthC = delegate (double a, double b, double c)
            {
                double mid = (a + b + c) / 3;
                return mid;
            };

            Muth muth = delegate
            {
                double mid = (muthA(1,2,3) + muthB(4,5,6) + muthC(7,8,9)) / 3;
                return mid;
            };

            Console.WriteLine(muth.Invoke(muthA,muthB,muthC));
            Console.ReadLine();
        }
    }
}
