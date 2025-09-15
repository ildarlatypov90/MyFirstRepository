namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string profession;

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();

            Console.WriteLine("Your occupation?");
            profession = Console.ReadLine();

            Greet(name, profession);
        }

        static void Greet(string name, string profession)
        {
            Console.WriteLine("Hello, {0}, {1}.", name, profession);
        }
    }
}
