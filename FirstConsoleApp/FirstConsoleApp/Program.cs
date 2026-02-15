namespace FirstConsoleApp
{
    internal class Program
    {
        class MainClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Напишите что-то");
                var str = Console.ReadLine();

                Console.WriteLine("Укажите глубину эха");
                var deep = int.Parse(Console.ReadLine());

                Echo(str, deep);

                Console.ReadKey();
            }

            static void Echo(string phrase, int deep)
            {
                ConsoleColor color = (ConsoleColor)Enum.GetValues(typeof(ConsoleColor)).GetValue(deep);
                Console.BackgroundColor = color;
                Console.WriteLine(phrase);

                if (deep > 1)
                {
                    Echo(phrase, deep - 1);
                }
            }
        }
    }
}   
