using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//3 - Создать класс Vehicle.
//В теле класса создайте поля: координаты и параметры средств передвижения(цена, скорость, год выпуска). 
//Создайте 3 производных класса Plane, Саг и Ship.
//Для класса Plane должна быть определена высота и количество пассажиров.
//Для класса Ship — количество пассажиров и порт приписки.
//Написать программу, которая выводит на экран информацию о каждом средстве передвижения.
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(10, 10, 1000000, 1000, 2010, 750, 100);
            Ship ship = new Ship(15, 15, 1500000, 500, 2018, 20, "Одесса");
            Car car = new Car(20, 20, 15000, 220, 2017);

            car.Show(car);
            plane.Show(plane);
            ship.Show(ship);

            Console.ReadLine();
        }
    }
}
