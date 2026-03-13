
namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


        }
        abstract class Delivery
        {
            public string Address { get; set; }
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

        abstract class Product
        {
            private string description { get; }
        }

        class Book : Product
        {
            private string description = "Книга";
            // только для чтения
            public string GetDescription()
            {
                return description;
            }
        }

        class Order<TDelivery, TStruct> where TDelivery : Delivery
        {
            public TDelivery Delivery;

            public int Number;

            public string Description;

            private List<Product> products;

            public Order()
            {
                this.Delivery = null;
                this.products = new List<Product>();
            }

            public Order(TDelivery inputDelivery)
            {
                this.Delivery = inputDelivery;
                this.products = new List<Product>();
            }

            public Order(TDelivery inputDelivery, Product inputProduct)
            {
                this.Delivery = inputDelivery;
                this.products = new List<Product>();
                this.products.Append(inputProduct);
            }

            public void DisplayAddress()
            {
                Console.WriteLine(Delivery.Address);
            }
            
            public void AddProduct(Product product)
            {
                products.Append(product);
            }
        }
    }
}
