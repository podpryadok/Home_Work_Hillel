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
    class Program
    {
        static void Main(string[] args)
        {
            Abonent abonent1 = new Abonent(1, "Ivanov", "Ivan", "Ivanovich", "city Dnipro",123456789, 0, 0, 100, 20);
            Abonent abonent2 = new Abonent(2, "Nikolov", "Nikolay", "Nikolaevich", "city Kiev", 987654321, 121, 234, 0, 50);
            Abonent abonent3 = new Abonent(3, "Alexov", "Alex", "Alexeevich", "city Harkov", 187461862, 200, 400, 249, 10);

            Abonents abonents = new Abonents();
            abonents.GetAbonents(abonent1);
            abonents.GetAbonents(abonent2);
            abonents.GetAbonents(abonent3);

            abonents.ShowAbonentsWorldTalk();

            Console.WriteLine("_________");

            abonents.ShowTopLocalTalk(10);

            Console.ReadLine();
        }
    }
}
