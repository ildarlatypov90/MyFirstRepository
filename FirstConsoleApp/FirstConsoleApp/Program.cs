using System.Net.NetworkInformation;
using Microsoft.VisualBasic.FileIO;

namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Ilatypov";
            string folderName = "new_Dir" + new Random().Next();
            
            GetCount(path);
            CreateDir(path, folderName);
            GetCount(path);
            DeleteDir(path+"\\"+folderName);

            Console.ReadKey();
        }
        static void DeleteDir(string fullPath)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
                dirInfo.Delete(true); // Удаление со всем содержимым
                Console.WriteLine("Каталог удален:{0}", fullPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void CreateDir(string path, string dirName)
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(path);
                if (!dirInfo.Exists)
                    dirInfo.Create();

                dirInfo.CreateSubdirectory(dirName);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static void GetCount(string path)
        {
            try
            { // Прописываем путь к корневой директории MacOS (для Windows скорее всего тут будет "C:\\")
                if (Directory.Exists(path)) // Проверим, что директория существует
                {
                    int count = 0;

                    Console.WriteLine("Всего файлов и папок:" 
                        + (Directory.GetDirectories(path).Length
                        + Directory.GetFiles(path).Length));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        class Drive
        {
            public string Name { get;  }
            public int TotalSize { get; }
            public int FreeSize { get; }
            Dictionary<string, Folder> Folders = new Dictionary<string, Folder>();

            public Drive(string name, int totalSize, int freeSize)
            {
                Name = name;
                TotalSize = totalSize;
                FreeSize = freeSize;
            }

            public void Create(string folderName)
            {
                Folders.Add(folderName, new Folder(folderName));

                Console.WriteLine("Папка {0} создана");
            }
        }

        public class Folder
        {
            string Name { get; set; }
            List<string> Files { get; set; } = new List<string>();

            public Folder(string name)
            {
                Name = name;
            }
            void AddFile(string name)
            {
                if (!Files.Contains(name)) Files.Add(name);
            }
        }
    }
}
