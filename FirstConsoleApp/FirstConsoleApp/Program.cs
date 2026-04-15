namespace FirstConsoleApp
{
    public class Program
    {
        public delegate int SumDelegate(int a, int b, int c);

        static void Main(string[] args)
        {
            SumDelegate sumDelegate = Sum;
            sumDelegate.Invoke(1, 10, 50);
            Console.ReadKey();
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }
    }
}
