using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace home_work_lecture2
{
    class Order : IComparable
    {
        //Это не удавшаяся итерация=(

        //Dannie platelshika
        public string namePlatelshik;
        public int innPlatelshik;
        
        //Dannie poluchatelya
        public string namePoluchatel;
        public string nameBankPoluch;
        public int innPoluchatel;
        public int schetPoluchatel;

        public int summaPerevoda;
        public ArrayList zapis;

        public ArrayList zapisDannih()//Zapis vseh dannih scheta
        {
            ArrayList order = new ArrayList();
            Console.WriteLine("Введите ИФО плательщика:");
            namePlatelshik = Console.ReadLine();
            order.Add(namePlatelshik);
            Console.WriteLine("Введите ИНН плательщика:");
            innPlatelshik = Convert.ToInt32(Console.ReadLine());
            order.Add(innPlatelshik);
            Console.WriteLine("Введите ИФО/Название компании получателя:");
            namePoluchatel = Console.ReadLine();
            order.Add(namePoluchatel);
            Console.WriteLine("Введите название Банка получателя:");
            nameBankPoluch = Console.ReadLine();
            order.Add(nameBankPoluch);
            Console.WriteLine("Введите ИНН получателя:");
            innPoluchatel = Convert.ToInt32(Console.ReadLine());
            order.Add(innPoluchatel);
            Console.WriteLine("Введите расчетный щет получателя:");
            schetPoluchatel = Convert.ToInt32(Console.ReadLine());
            order.Add(schetPoluchatel);
            Console.WriteLine("Введите сумму перевода:");
            summaPerevoda = Convert.ToInt32(Console.ReadLine());
            order.Add(summaPerevoda);

            return zapis = order;
        }

        public int CompareTo(object o)//Sortirovka s pomoshiy interfeisa
        {
            Order or = o as Order;
            if (or != null)
                return this.summaPerevoda.CompareTo(or.summaPerevoda);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }
}
