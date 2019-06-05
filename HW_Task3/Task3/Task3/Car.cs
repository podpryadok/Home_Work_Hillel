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
    class Car
    {
        private string markaCar;
        private int idCar;
        private bool occupantCar;
        private bool needToFix;

        public int IdAuto { get => idCar; }
        public string MarkaAuto { get => markaCar; }
        public bool OccupantCar { get => occupantCar; }
        public bool NeedToFix { get => needToFix; }

        public Car(string markaCar, int idCar)
        {
            this.markaCar = markaCar;
            this.idCar = idCar;
            occupantCar = false;
            needToFix = false;
        }

        public void GetCar(Car car)//Назначаем машину на водителя
        {
            occupantCar = true;
        }

        public void WantFix(Car car)//Необходим ремонт машине.
        {
            needToFix = true;
        }
    }
}
