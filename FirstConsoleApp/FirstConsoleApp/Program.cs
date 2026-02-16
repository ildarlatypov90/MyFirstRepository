namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string family, int age, bool isHavePet,
                 int petCount, string[] petsNames, string[] colors) Anketa;

            Anketa = Program.GetAnketa();

            return;
        }

        static (string name, string family, int age, bool isHavePet,
                 int petCount, string[] petsNames, string[] colors) GetAnketa()
        {
            string name = "";
            string family = "";
            int age = 0;
            bool isHavePet = false;
            int petCount = 0;
            string[] petsNames = new string[0];
            string[] colors = new string[0];

            Console.WriteLine("Введите ваше имя:");
            name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию:");
            family = Console.ReadLine();

            string ageR;
            Console.WriteLine("Введите ваш возраст:");
            do
            {
                ageR = Console.ReadLine();
            } while (Program.CheckInt(ageR, out age));

            Console.WriteLine("Есть ли у вас питомец/питомцы (да/нет):");
            string answer = "";
            answer = Console.ReadLine();
            if (answer.ToLower() == "да")
                isHavePet = true;
            else
                isHavePet = false;

            if (isHavePet)
            {
                Console.WriteLine("Сколько у вас питомцев?");
                petCount = int.Parse(Console.ReadLine());

                petsNames = new string[petCount];
                Console.WriteLine("Введите имена питомцев.");
                for (int i = 0; i < petCount; i++)
                {
                    Console.WriteLine("Имя питомца {0}", i + 1);
                    petsNames[i] = Console.ReadLine();
                }
            }

            return (name, family, age, isHavePet,
                petCount, petsNames, colors);

        }

        static bool CheckInt(string inputParam, out int corrNumber)
        {
            int intNum;
            
            if (int.TryParse(inputParam, out intNum))
            {
                if (intNum > 0)
                {
                    corrNumber = intNum;
                    return true;
                }
            }

            corrNumber = 0;
            return false;
        }
    }
}
