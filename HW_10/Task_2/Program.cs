using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создайте четыре лямбда оператора для выполнения арифметических действий: 
//(Add – сложение, Sub – вычитание, Mul – умножение, Div – деление). 
//Каждый лямбда оператор должен принимать два аргумента и возвращать результат вычисления.
//Лямбда оператор деления должен делать проверку деления на ноль.Написать программу,
//которая будет выполнять арифметические действия указанные пользователем.
namespace Task_2
{
    delegate double Add(double a, double b);
    delegate double Sub(double a, double b);
    delegate double Mul(double a, double b);
    delegate double Div(double a, double b);

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Add add = (x, y) => x + y;
                Sub sub = (x, y) => x - y;
                Mul mul = (x, y) => x * y;
                Div div = (x, y) => x / y;
                Console.WriteLine("Введите команду: Add - сложение, Sub - вычитание, Mul - умножение, Div - деление.");
                string userComand = Console.ReadLine();

                Console.WriteLine("Введите числа для операции: \nПервое число:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Второе число: ");
                double b = Convert.ToDouble(Console.ReadLine());
                switch (userComand)
                {
                    case "Add":
                    case "add":
                        Console.WriteLine("Сумма = " + add(a,b));
                        break;
                    case "Sub":
                    case "sub":
                        Console.WriteLine("Вычитание = " + sub(a,b));
                        break;
                    case "Mul":
                    case "mul":
                        Console.WriteLine("Умножение = " + mul(a, b));
                        break;
                    case "Div":
                    case "div":
                        if (a == 0 || b==0)
                        {
                            Console.WriteLine("Деление на ноль!");
                        }
                        else { Console.WriteLine("Деление = " + div(a, b)); }
                        break;
                }
            }
        }
    }
}
