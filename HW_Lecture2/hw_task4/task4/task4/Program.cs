using System;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны 'А':");
            double s1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите длину стороны 'B':");
            double s2 = Convert.ToDouble(Console.ReadLine());

            Rectangle rectangle1 = new Rectangle(s1, s2);
            rectangle1.AreaCalculator();
            rectangle1.PerimetrCalculator();

            Console.WriteLine("Периметр = {0}; Площадь = {1};", rectangle1.Perimeter, rectangle1.Area);
            Console.ReadKey();
        }
    }
}
