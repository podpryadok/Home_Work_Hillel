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
    class Vehicle
    {
        private double coordinateX;
        private double coordinateY;
        private double price;
        private double speed;
        private int sinceYear;

        public double CoordinateX { get => coordinateX; }
        public double CoordinateY { get => coordinateY; }
        public double Price { get => price; }
        public double Speed { get => speed; }
        public int SinceYear { get => sinceYear; }

        public Vehicle(double coordinateX, double coordinateY, double price, double speed, int sinceYear)
        {
            this.coordinateX = coordinateX;
            this.coordinateY = coordinateY;
            this.price = price;
            this.speed = speed;
            this.sinceYear = sinceYear;
        }

        public virtual void Show(Vehicle vehicle)
        {
            Console.WriteLine($"Координаты X:{vehicle.coordinateX} Y:{vehicle.coordinateY};\nЦена: {vehicle.price} долларов, Скорость: {vehicle.speed} км/ч., Год выпуска: {vehicle.sinceYear};");
        }
    }

    class Plane : Vehicle
    {
        private double maxHight;
        private int maxPasager;

        public double MaxHight { get => maxHight; }
        public int MaxPasager { get => maxPasager; }

        public Plane(double coordinateX, double coordinateY, double price, double speed, int sinceYear, double maxHight, int maxPasager) 
            : base(coordinateX, coordinateY, price, speed, sinceYear)
        {
            this.maxHight = maxHight;
            this.maxPasager = maxPasager;
        }

        public override void Show(Vehicle vehicle)
        {
            Console.WriteLine("Самолёт: ");
            base.Show(vehicle);
            Console.WriteLine($"Максимальная высота полёта: {maxHight} метров, Максимальное число пасажиров: {maxPasager}.");
        }
    }

    class Ship : Vehicle
    {
        private int maxPasager;
        private string homePort;

        public int MaxPasager { get => maxPasager; }
        public string HomePort { get => homePort; }

        public Ship(double coordinateX, double coordinateY, double price, double speed, int sinceYear, int maxPasager, string homePort) 
            : base(coordinateX, coordinateY, price, speed, sinceYear)
        {
            this.maxPasager = maxPasager;
            this.homePort = homePort;
        }

        public override void Show(Vehicle vehicle)
        {
            Console.WriteLine("Корабль: ");
            base.Show(vehicle);
            Console.WriteLine($"Максимальное число пасажиров: {maxPasager}, Порт приписки: {homePort}.");
        }
    }

    class Car : Vehicle
    {
        public Car(double coordinateX, double coordinateY, double price, double speed, int sinceYear) 
            : base(coordinateX, coordinateY, price, speed, sinceYear)
        {
        }

        public override void Show(Vehicle vehicle)
        {
            Console.WriteLine("Машина: ");
            base.Show(vehicle);
        }
    }
}
