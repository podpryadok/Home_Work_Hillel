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
    class Race
    {
        private string nameRace;
        private bool occupantRace;
        private bool completeRace;

        public bool OccupantRace { get => occupantRace; }
        public string NameRace { get => nameRace; }       
        public bool CompleteRace { get => completeRace; }

        public Race(string nameRace)
        {
            this.nameRace = nameRace;
            occupantRace = false;
            completeRace = false;
        }


        public void DoRace(Race race)//назначаем рейс
        {
            occupantRace = true;
        }

        public void Complete(Race race)//Выполнение рейса
        {
            race.completeRace = true;
        }
    }
}
