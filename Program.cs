namespace CurrencyConverter
{
    public class Program
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            DisplayConverter display = new DisplayConverter();
            display.ShowWelcomeMessage();
            display.ShowLoadingAnimation();
            display.ShowOptions();
            
        }
    }
}