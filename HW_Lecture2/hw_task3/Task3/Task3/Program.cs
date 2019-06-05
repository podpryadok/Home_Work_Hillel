using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
//Определить класс с именем Prise содержащую следующие поля:

//название товара;
//название магазина, в котором продается товар;
//стоимость товара в грн.методы:
//ввод данных в массив из n элементов в типа Prise;
//упорядочить в алфавитном порядке по названиям товаров;
//вывод информации о товаре, название которого ввел пользователь.
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Price price1 = new Price("Куртка", "Brand_Shop", 100);
            Price price2 = new Price("Штаны", "Brand_Shop", 40);
            Price price3 = new Price("Футболка", "Brand_Shop", 50);

            Prices prices = new Prices();
            prices.GetPrice(price1);
            prices.GetPrice(price2);
            prices.GetPrice(price3);

            prices.Print(true);
            Console.WriteLine("-");
            prices.Print("Футболка");

            Console.ReadLine();
        }
    }
}
