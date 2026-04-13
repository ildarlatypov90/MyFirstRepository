using System.Text.Json;

namespace FirstConsoleApp
{
    [Serializable]
    class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Объект для сериализации
            Pet pet = new Pet("Rex", 2);
            Console.WriteLine("Объект создан");

            string fileName = "C:\\Users\\Ilatypov\\myPets.json";

            // Сериализация
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonString = JsonSerializer.Serialize(pet, options);
            File.WriteAllText(fileName, jsonString);
            Console.WriteLine("Объект сериализован");

            // Десериализация
            jsonString = File.ReadAllText(fileName);
            Pet newPet = JsonSerializer.Deserialize<Pet>(jsonString);
            Console.WriteLine("Объект десериализован");

            Console.WriteLine($"Имя: {newPet.Name} --- Возраст: {newPet.Age}");
            Console.ReadLine();
        }
    }
}
