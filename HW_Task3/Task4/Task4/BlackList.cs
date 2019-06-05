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
    class BlackList
    {
        private List<Client> black_List;

        public List<Client> Black_List { get => black_List; }

        public BlackList()
        {
            black_List = new List<Client>();
        }

        public void AddClientToBlackList(Client client)
        {
            black_List.Add(client);
        }
    }
}
