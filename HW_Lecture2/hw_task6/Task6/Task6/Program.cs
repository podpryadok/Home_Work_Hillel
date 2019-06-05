using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Создать классы Point и Figure.
//Класс Point должен содержать два целочисленных поля и одно строковое поле.
//Создать три свойства с одним методом доступа get.
//Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями аргументов.
//Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти аргументов типа Point. 
//Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину стороны многоугольника; 
//void PerimeterCalculator(), который рассчитывает периметр многоугольника.
//Написать программу, которая выводит на экран название и периметр многоугольника.
namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Point pointA = new Point(10,20,"A");
            Point pointB = new Point(10, 20, "B");
            Point pointC = new Point(20, 30, "C");
            Figure figure1 = new Figure(pointA,pointB,pointC);
            
            
            Console.WriteLine(figure1.LengthSide(pointA, pointB));
            Console.WriteLine(figure1.PerimeterCalculator(pointA,pointB));
            Console.WriteLine(figure1.Name);
            Console.ReadLine();
        }
    }
}
