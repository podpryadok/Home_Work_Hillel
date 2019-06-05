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
    class Abonent
    {
        private long userID;
        private string firstName;
        private string lastName;
        private string otchestvo;
        private string adres;
        private long creditCart;
        private double debit;
        private double credit;
        private int timeWorldTalk;
        private int timeLockalTalk;

        public long UserID { get => userID; }
        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public string Otchestvo { get => otchestvo; }
        public string Adres { get => adres; }
        public long CreditCart { get => creditCart; }
        public double Debit { get => debit; }
        public double Credit { get => credit; }
        public int TimeWorldTalk { get => timeWorldTalk; }
        public int TimeLockalTalk { get => timeLockalTalk; }

        public Abonent(long id, string fName, string lName, string otch, string adres, long creditCart, double debit, double credit, int timeWorld, int timeLokal)
        {
            userID = id;
            firstName = fName;
            lastName = lName;
            otchestvo = otch;
            this.adres = adres;
            this.creditCart = creditCart;
            this.debit = debit;
            this.credit = credit;
            timeWorldTalk = timeWorld;
            timeLockalTalk = timeLokal;
        }

        public void AddTimeToWorldTalk(int time)
        {
            timeWorldTalk += time;
        }

        public void AddTimeToLokalTalk(int time)
        {
            timeLockalTalk += time;
        }

        public void AddDebit(double count)
        {
            debit += count;
        }

        public void MinusDebit(double count)
        {
            debit -= count;
        }

        public void MinusCredit(double count)
        {
            credit -= count;
        }

        public void AddCredit(double count)
        {
            credit += count;
        }

        public void Show()
        {
            Console.WriteLine($"{userID}:{firstName} {lastName} {otchestvo}, {adres}, {creditCart}");
            Console.WriteLine($"Дебит:{debit}; Кредит:{credit}; Время разговоров за рубеж: {TimeWorldTalk}; Время локальных разговоров: {timeLockalTalk}");
        }
    }
}
