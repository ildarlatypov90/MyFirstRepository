
namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("1001 способ написать говнокод");
            Console.WriteLine(b.type, b.description);

            Console.ReadKey();
        }
        abstract class Delivery
        {
            public string address { get; set; }
        }

        class HomeDelivery : Delivery
        {
            protected DateTime date; // время доставки
            protected string address { get; set; }
            /* ... */
            public HomeDelivery(string iHomeAddress, DateTime iDate)
            {
                address = iHomeAddress;
                date = iDate;
            }
        }

        class PickPointDelivery : Delivery
        {
            public string[] addresses = {
                "ул. Валидольная 4",
                "ул. Карвалольная 5",
                "ул. Ленина 1" };
            
            protected string address {
                get
                {
                    // вернуть ближайший к пользователю, для теста верну просто 0.
                    return addresses[0];
                }
            }
        }

        class ShopDelivery : Delivery
        {
            public static TimeOnly startDate = new TimeOnly(9,0);
            public static TimeOnly endDate = new TimeOnly(22,0);

            static public void ShowWorkHours()
            {
                Console.Write("Время работы {0} - {1}", ShopDelivery.startDate, ShopDelivery.endDate);
            }
        }

        abstract class Product
        {
            public string type { get; }
            public string description { get; set; }
        }

        class Book : Product
        {
            public static string iType = "Книга";
            public string type
            {
                get
                {
                    return Book.iType;
                }
            }

            public Book(string iDescription)
            {
                description = iDescription;
            }
        }

        class Order<TDelivery, TStruct> where TDelivery : Delivery
        {
            public TDelivery delivery;

            public int Number;

            public string Description;

            protected List<Product> products;

            public Order()
            {
                this.delivery = null;
                this.products = new List<Product>();
            }

            public Order(TDelivery inputDelivery)
            {
                this.delivery = inputDelivery;
                this.products = new List<Product>();
            }

            public Order(TDelivery inputDelivery, Product inputProduct)
            {
                this.delivery = inputDelivery;
                this.products = new List<Product>();
                this.products.Append(inputProduct);
            }

            public void DisplayAddress()
            {
                Console.WriteLine(delivery.address);
            }
            
            public void AddProduct(Product product)
            {
                products.Append(product);
            }
        }
    }
}
