using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Разработать систему «Автобаза». 
//Диспетчер распределяет заявки на Рейсы между Водителями и назначает для этого Автомобиль.
//Водитель может сделать заявку на ремонт.Диспетчер может отстранить Водителя от работы. 
//Водитель делает отметку о выполнении Рейса и состоянии Автомобиля.
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver1 = new Driver("Chel");
            Driver driver2 = new Driver("Vasya");

            Car car1 = new Car("Daf", 1234);
            Car car2 = new Car("Man", 4321);

            Race race1 = new Race("Vivoz musora");
            Race race2 = new Race("Perevoz drov");
            Dispetcher dispetcher = new Dispetcher();

            dispetcher.GetCarToDriver(driver1, car1);
            dispetcher.SetRace(driver1, race1);
            driver1.Show();
            driver1.CompleteRace(true);

            Console.WriteLine("___________");
            dispetcher.SetRace(driver2, race2);

            Console.WriteLine("__________");
            dispetcher.GetCarToDriver(driver1, car2);
            dispetcher.SetRace(driver1, race2);

            driver1.Show();
            //driver2.Show();
            Console.ReadLine();
        }
    }
}
