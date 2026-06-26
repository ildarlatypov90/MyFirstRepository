namespace FirstConsoleApp
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public bool IsPremium { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                new User { Login = "alex2", Name = "Алексей", IsPremium = true },
                new User { Login = "vasya0491", Name = "Василий", IsPremium = false },
                new User { Login = "dominator3000", Name = "Олег", IsPremium = true }
            };

            for (int i = 0; i < users.Length; i++)
            {
                var user = users[i];

                if (!user.IsPremium)
                {
                    Console.WriteLine("Здравствуйте {0}. ", user.Name);
                    ShowAds();
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Здравствуйте {0}! \n", user.Name);
                }
            }


        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
