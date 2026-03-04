namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
        abstract class Delivery
        {
            public string Address;
        }

        class HomeDelivery : Delivery
        {
            /* ... */
        }

        class PickPointDelivery : Delivery
        {
            /* ... */
        }

        class ShopDelivery : Delivery
        {
            /* ... */
        }

        class Product
        { }

        class Order<TDelivery, TStruct> where TDelivery : Delivery
        {
            public TDelivery Delivery;

            public int Number;

            public string Description;

            private Product[] products;

            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }
        }
    }
}
