using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
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
    class Prices
    {
        private List<Price> prices;
        private List<Price> temp;

        public Prices()
        {
            prices = new List<Price>();
            temp = new List<Price>();
        }

        public void GetPrice(Price price)
        {
            prices.Add(price);
        }

        public void Print(string userNameObject)
        {
            foreach (var price in prices)
            {
                if (userNameObject == price.NameObject)
                {
                    Show(price);
                }
            }
        }

        public void Print(bool isSorted)
        {
            if (isSorted)
                temp = prices.OrderBy(x => x.NameObject).ToList();

            foreach (var tm in temp)
            {
                Show(tm);
            }
        }

        public void Show(Price price)
        {
            Console.WriteLine($"{price.NameObject}->{price.Shop}->{price.PriceToObject}");
        }
    }
}
