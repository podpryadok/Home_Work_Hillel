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
    class Price
    {
        private string nameObject;
        private string shop;
        private int priceToObject;

        public string NameObject { get => nameObject; }
        public string Shop { get => shop; }
        public int PriceToObject { get => priceToObject; }

        public Price(string name, string shop, int priceToObject)
        {
            this.nameObject = name;
            this.shop = shop;
            this.priceToObject = priceToObject;
        }
    }
}
