//Разработать систему «Интернет-магазин». 
//Товаровед добавляет информацию о Товаре.
//Клиент делает и оплачивает Заказ на Товары.
//Товаровед регистрирует Продажу и может занести неплательщика в «черный список».
namespace Task4
{
    class Client
    {
        private string clientFullName;
        private string adresClient;
        private long clientId;

        public string ClientFullName { get => clientFullName; }
        public string AddresClient { get => adresClient; }
        public long ClientId { get => clientId; }

        public Client(string clientName, string adresClient, long id)
        {
            this.clientFullName = clientName;
            this.adresClient = adresClient;
            clientId = id;
        }

        public void DoOrder(Produkt produkt, BlackList blackList)
        {
            foreach (var clientBlack in blackList.Black_List)
            {
                if (clientBlack.clientId == clientId)
                {
                    System.Console.WriteLine("Вы в черном списке! Оплатите свой предыдущий заказ!");
                }
                else
                {
                    produkt.GoToClient();
                }
            }
        }

        public void PayForProdukt(Produkt produkt)
        {
            produkt.ProduktPay();
        }
    }
}
