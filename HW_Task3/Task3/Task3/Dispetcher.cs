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
    class Dispetcher
    {
        public void SetRace(Driver driver, Race race)//Отправка в рейс
        {
            if (race.OccupantRace == false)
            {
                if (driver.CanDrive == true)
                {
                    if (driver.UseCar != null)
                    {
                        race.DoRace(race);
                        driver.GetRace(race);
                        driver.Suspended(driver);
                    }
                    else
                    {
                        Console.WriteLine("У водителя не назначена машина!");
                    }
                }
                else
                {
                    Console.WriteLine("Водитель занят, либо отстранён!");
                }
            }
            else
            {
                Console.WriteLine("Рейс уже назначен!");
            }


        }

        public void GetCarToDriver(Driver driver, Car car)//Назначение машины на водителя
        {
            if (car.OccupantCar == false && car.NeedToFix == false)
            {
                if (driver.UseCar == null && driver.CanDrive == true)
                {
                    driver.GetCar(car);
                    car.GetCar(car);
                }
                else
                {
                    Console.WriteLine("У водителя назначена машина или водитель отстранён!");
                }

            }
            else
            {
                Console.WriteLine("Машина занята, либо в ремонте!");
            }

        }

        public void DriverGoHome(Driver driver)//Отстронение водителя от работы
        {
            driver.Suspended(driver);
        }
    }
}
