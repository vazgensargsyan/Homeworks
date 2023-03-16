namespace Lesson8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CurrencyExchange currencyExchange = new CurrencyExchange();
            currencyExchange.Exchange(19, "dollar");
        }
    }
}