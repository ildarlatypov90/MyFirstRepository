namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Jane";
            int age = 28;
            bool havePets = false;
            float shoe_size = 37.5f;

            Console.WriteLine("My name is {0} \n " +
                "MyAge {1} \n " +
                "Do I have a pet? {2} \n " +
                "My shoe size is {3} ", name, age, havePets, shoe_size);

            Console.ReadKey();
        }
    }
}
