namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            byte pow;

            Console.WriteLine("Ведите число которое необходимовозвети в степень:");
            N = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите степень, в которое необходимо возвести число(не более 255):");
            pow = byte.Parse(Console.ReadLine());

            Console.WriteLine(Program.PowerUp(N, pow));
            Console.ReadLine();
        }

        private static int PowerUp(int N, byte pow)
        {
            int res = 1;
            if (pow > 1)
            {
                res = N * Program.PowerUp(N, (byte)(pow-1));
            }
            else if (pow == 1)
            {
                res = N;
            }

            return res;
        }
    }
}
