using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Класс Абонент: Идентификационный номер, Фамилия, Имя, Отчество, Адрес, Номер кредитной карточки, Дебет, Кредит, 
//Время междугородных и городских переговоров; Конструктор; 
//Методы: установка значений атрибутов, получение значений атрибутов, вывод информации.
//Создать массив объектов данного класса. 
//Вывести сведения относительно абонентов, у которых время городских переговоров превышает заданное.
//Сведения относительно абонентов, которые пользовались междугородной связью. Список абонентов в алфавитном порядке.
namespace Task2
{
    class Abonents
    {
        private List<Abonent> abonents;
        private List<Abonent> temp;

        public Abonents()
        {
            abonents = new List<Abonent>();
            temp = new List<Abonent>();
        }

        public void GetAbonents(Abonent abonent)
        {
            abonents.Add(abonent);
        }

        public void ShowTopLocalTalk(int userCount)
        {
            foreach (var abonent in abonents )
            {
                if(userCount < abonent.TimeLockalTalk)
                {
                    Show(abonent);
                }
            }
        }

        public void ShowAbonentsWorldTalk()
        {
            foreach (var abonent in abonents)
            {
                if(abonent.TimeWorldTalk > 0)
                {
                    temp.Add(abonent);
                }
            }
            temp = abonents.OrderBy(x => x.FirstName).ToList();
            foreach (var tm in temp)
            {
                Show(tm);
            }            
        }

        private void Show(Abonent abonent)
        {
            Console.WriteLine($"{abonent.UserID}:{abonent.FirstName} {abonent.LastName} {abonent.Otchestvo}, {abonent.Adres}, {abonent.CreditCart}");
            Console.WriteLine($"Дебит:{abonent.Debit}; Кредит:{abonent.Credit}; Время разговоров за рубеж: {abonent.TimeWorldTalk}; Время локальных разговоров: {abonent.TimeLockalTalk}");
        }
    }
}
