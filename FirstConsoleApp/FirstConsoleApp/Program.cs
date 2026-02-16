namespace FirstConsoleApp
{
    internal class Program
    {
        class MainClass
        {
            static void Main(string[] args)
            {
                Console.WriteLine(Factorial(20));
                Console.ReadKey();
            }

            static decimal Factorial(int x)
            {
                if (x == 0)
                {
                    return 1;
                }
                else
                {
                    return x * Factorial(x - 1);
                }
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
