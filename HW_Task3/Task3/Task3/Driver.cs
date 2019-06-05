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
    class Driver
    {
        private string nameDriver;
        private bool canDrive;

        private Car useCar;
        private Race doRace;

        public string NameDriver { get => nameDriver; }
        public bool CanDrive { get => canDrive; }
        public Car UseCar { get => useCar; }
        public Race DoRace { get => doRace; }

        public Driver(string nameDriver)
        {
            this.nameDriver = nameDriver;
            canDrive = true;
        }


        public void Suspended(Driver driver)//Отстронить водителя от работы или занять его
        {
            canDrive = false;
        }

        public void GetCar(Car car)//Закрепляется машина за водителем
        {
            useCar = car;
        }

        public void GetRace(Race race)//Назначается рейс
        {
            doRace = race;
        }

        public void WantFixCar(Car car)//Запрос на ремонт машины
        {
            car.WantFix(car);
        }

        public void CompleteRace(bool wantFix)//Отчет о выполнении рейса
        {
            canDrive = true;
            doRace.Complete(doRace);
            doRace = null;
            if(wantFix == true)
            {
                WantFixCar(useCar);
            }
        }

        public void Show()
        {
                Console.WriteLine($"Имя:{nameDriver}, Занят? {canDrive}, Машина:{useCar.MarkaAuto}, Рейс:{doRace.NameRace}");            
        }
    }
}
