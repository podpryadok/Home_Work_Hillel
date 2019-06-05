//Разработать систему «Интернет-магазин». 
//Товаровед добавляет информацию о Товаре.
//Клиент делает и оплачивает Заказ на Товары.
//Товаровед регистрирует Продажу и может занести неплательщика в «черный список».
namespace Task4
{
    class Produkt
    {
        private string produktName;
        private bool isInStock;
        private double priceProdukt;
        private bool produktPaid;

        public string ProduktName { get => produktName; }
        public bool IsInStock { get => isInStock; }
        public double PriceProdukt { get => priceProdukt; }
        public bool ProduktPaid { get => produktPaid; }

        public Produkt()
        {

        }

        public void SetProdukt(string produktName, double priceProdukt)
        {
            this.produktName = produktName;
            this.priceProdukt = priceProdukt;
            isInStock = true;
        }

        public void GoToClient()
        {
            isInStock = false;
            produktPaid = false;
        }

        public void ProduktPay()
        {
            produktPaid = true;
        }
    }
}
