//Разработать систему «Интернет-магазин». 
//Товаровед добавляет информацию о Товаре.
//Клиент делает и оплачивает Заказ на Товары.
//Товаровед регистрирует Продажу и может занести неплательщика в «черный список».
namespace Task4
{
    class Tavaroved
    {
        public void SetProduct(Produkt produkt, string produktName, double produktPrice)
        {
            produkt.SetProdukt(produktName, produktPrice);
        }

        public void ReserchToPaid(Client client, Produkt produkt, BlackList blackList)
        {
            if(produkt.ProduktPaid == false)
            {
                blackList.AddClientToBlackList(client);
                System.Console.WriteLine("Отправлен в черный список!");
            }
            else
            {
                System.Console.WriteLine("Платёж подтверждён.");
            }
        }
    }
}
