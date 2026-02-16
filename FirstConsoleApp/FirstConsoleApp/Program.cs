namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            (string name, string family, int age, bool isHavePet,
                 int petCount, string[] petsNames, string[] colors) Anketa;

            Anketa = Program.GetAnketa();

            Program.ShowAnketa(Anketa);

            Console.ReadKey();

            return;
        }

        static (string name, string family, int age, bool isHavePet,
                 int petCount, string[] petsNames, string[] colors) GetAnketa()
        {
            string name     = "";
            string family   = "";
            int age         = 0;
            bool isHavePet  = false;
            int petCount    = 0;
            string[] petsNames  = new string[0];
            string[] colors     = new string[0];

            Console.WriteLine("Введите ваше имя:");
            name = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию:");
            family = Console.ReadLine();

            string ageR;
            do
            {
                Console.WriteLine("Введите ваш возраст цифрами:");
                ageR = Console.ReadLine();
            } while (!Program.CheckInt(ageR, out age));

            Console.WriteLine("Есть ли у вас питомец/питомцы (да/нет):");
            string answer = "";
            answer = Console.ReadLine();
            if (answer.ToLower() == "да")
                isHavePet = true;
            else
                isHavePet = false;

            if (isHavePet)
            {
                string petCountR;
                do
                {
                    Console.WriteLine("Сколько у вас питомцев цифрами:");
                    petCountR = Console.ReadLine();
                } while (!Program.CheckInt(petCountR, out petCount));

                petsNames = new string[petCount];
                Console.WriteLine("Введите имена питомцев.");
                for (int i = 0; i < petCount; i++)
                {
                    Console.WriteLine("Имя питомца {0}", i + 1);
                    petsNames[i] = Console.ReadLine();
                }
            }

            int colorsCount;
            string colorsCountR;
            do
            {
                Console.WriteLine("Введите количество любимых цветов цифрами:");
                colorsCountR = Console.ReadLine();
            } while (!Program.CheckInt(colorsCountR, out colorsCount));

            colors = Program.GetColors(colorsCount);

            return (name, family, age, isHavePet,
                petCount, petsNames, colors);
        }

        static string[] GetColors(int colorsCount)
        {
            string[] colors = new string[colorsCount];

            for (int i=0; i < colorsCount; i++)
            {
                Console.WriteLine("Введите любимый {0} цвет", i + 1);
                colors[i] = Console.ReadLine();
            }

            return colors;
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

        static void ShowAnketa((string name, string family, int age, bool isHavePet,
                 int petCount, string[] petsNames, string[] colors) Anketa)
        {
            Console.WriteLine("Вас зовут {0} {1}.", Anketa.family, Anketa.name);
            Console.WriteLine("Ваш возраст {0}.", Anketa.age);
            if (Anketa.petsNames.Length>0)
            {
                Console.WriteLine("У вас есть питомцы: {0}", string.Join(", ", Anketa.petsNames));
            }
            if (Anketa.colors.Length>0)
            {
                Console.WriteLine("Ваши любимые цвета: {0}", string.Join(", ", Anketa.colors));
            }
        }
    }
}
