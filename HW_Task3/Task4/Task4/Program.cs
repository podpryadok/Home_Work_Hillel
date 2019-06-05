using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Разработать систему «Интернет-магазин». 
//Товаровед добавляет информацию о Товаре.
//Клиент делает и оплачивает Заказ на Товары.
//Товаровед регистрирует Продажу и может занести неплательщика в «черный список».
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Tavaroved tavaroved = new Tavaroved();
            BlackList blackList = new BlackList();
            Client client1 = new Client("Сеня", "Днепр", 1);
            Client client2 = new Client("Вася", "Киев", 2);
            Produkt produkt1 = new Produkt();
            Produkt produkt2 = new Produkt();

            tavaroved.SetProduct(produkt1, "Носки", 10.50);
            tavaroved.SetProduct(produkt2, "Джинсы", 40);

            client1.DoOrder(produkt1, blackList);
            //client1.PayForProdukt(produkt1);

            tavaroved.ReserchToPaid(client1, produkt1, blackList);

            client1.DoOrder(produkt2, blackList);

            Console.ReadLine();
        }
    }
}
