namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string Name, string[] Dishes) User;
            int len = 5;

            Console.WriteLine("Введите имя:");
            User.Name = Console.ReadLine();

            User.Dishes = new string[len];

            for (int i = 0; i < User.Dishes.Length; i++)
            {
                Console.WriteLine("Введите любимое блюдо {0}:", i+1);
                User.Dishes[i] = Console.ReadLine();
            }

            Console.ReadKey();
        }

        static string GetDataFromConsole() => Console.ReadLine();

        int SumNumbers(ref int num1, in int num2, out int num3, int num4)
        {

        }
    }
}   
