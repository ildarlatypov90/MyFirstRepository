namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                throw new ArgumentOutOfRangeException("Message for ArgumentOutOfRangeException");
                // throw new RankException("Message for RankException");
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                Console.WriteLine("Is ArgumentOutOfRangeException exception");
            }
            catch (Exception ex) when (ex is RankException)
            {
                Console.WriteLine("Is RankException exception");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Is {0} exception", ex.GetType());
            }

            Console.ReadKey();
            }

    }
}
