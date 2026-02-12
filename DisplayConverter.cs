using System.Text;

namespace CurrencyConverter
{
    public class DisplayConverter
    {

        public int x;
        public decimal amount, converted;
        public string yorn;

        Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal>
        {
            { "BRL", 5.25m },
            { "EUR", 0.85m },
            { "GBP", 0.75m },
            { "JPY", 110.00m },
            { "INR", 74.00m },
            { "CAD", 1.25m },
            { "AUD", 1.35m },
            { "CNY", 6.45m }
        };

        public void ShowWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Currency Converter!\n\n");
            Console.WriteLine("This application allows you to convert amounts between different currencies.");
            Console.WriteLine("You can choose from a variety of currencies and input the amount you wish to convert.\n");
            Console.WriteLine("Let's get started!");
            Console.ReadKey();
        }
        public void ShowGoodbyeMessage()
        {
            Console.WriteLine("\nThank you for using the Currency Converter. Goodbye!");
            Console.ReadKey();
        }
        public void ShowOptions()
        {
            x = 0;

            Console.Clear();
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Convert Currency");
            Console.WriteLine("2. View Exchange Rates");
            Console.WriteLine("0. Exit");
            x = Convert.ToInt32(Console.ReadLine());

            switch (x)
            {
                case 1:
                    ShowLoadingAnimation();
                    ShowResults();
                    break;
                case 2:
                    ShowLoadingAnimation();
                    ShowExchangeRates();
                    break;
                case 0:
                    ShowLoadingAnimation();
                    ShowGoodbyeMessage();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        public void ShowLoadingAnimation()
        {
            Console.Clear();
            Console.Write("Loading");
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                Thread.Sleep(250);
            }
            Console.Clear();
        }
        public void ShowDisplayResult()
        {
            Console.Clear();
            Console.WriteLine("Conversion Result:\n");
            Console.Write("Amount in USD: $ ");
            amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("\nAvailable Currencies:\n");
            Console.WriteLine($"1. R$ - BRL - Brazilian Real");
            Console.WriteLine($"2. € - EUR - Euro");
            Console.WriteLine($"3. £ - GBP - British Pound");
            Console.WriteLine($"4. ¥ - JPY - Japanese Yen");
            Console.WriteLine($"5. ₹ - INR - Indian Rupee");
            Console.WriteLine($"6. C$ - CAD - Canadian Dollar");
            Console.WriteLine($"7. A$ - AUD - Australian Dollar");
            Console.WriteLine($"8. CN¥ - CNY - Chinese Yuan");
            Console.WriteLine("\n0. Back");
            x = Convert.ToInt32(Console.ReadLine());
        }
        public void ShowConversionResult()
        {
            int def = 0;
            do
            {
                switch (x)
                {
                    case 1:
                        converted = amount * exchangeRates["BRL"];
                        Console.WriteLine($"Converted Amount: R$ {converted}");
                        Console.WriteLine($"\nThe Brazilian Real (BRL) is the official currency of Brazil. It is symbolized by R$ and is subdivided into 100 centavos. The exchange rate for BRL is currently {exchangeRates["BRL"]} per USD.");
                        break;
                    case 2:
                        converted = amount * exchangeRates["EUR"];
                        Console.WriteLine($"Converted Amount: € {converted}");
                        Console.WriteLine($"\nThe Euro (EUR) is the official currency of the Eurozone, which consists of 19 of the 27 European Union member states. It is symbolized by € and is subdivided into 100 cents. The exchange rate for EUR is currently {exchangeRates["EUR"]} per USD.");
                        break;
                    case 3:
                        converted = amount * exchangeRates["GBP"];
                        Console.WriteLine($"Converted Amount: £ {converted}");
                        Console.WriteLine($"\nThe British Pound (GBP) is the official currency of the United Kingdom. It is symbolized by £ and is subdivided into 100 pence. The exchange rate for GBP is currently {exchangeRates["GBP"]} per USD.");
                        break;
                    case 4:
                        converted = amount * exchangeRates["JPY"];
                        Console.WriteLine($"Converted Amount: ¥ {converted}");
                        Console.WriteLine($"\nThe Japanese Yen (JPY) is the official currency of Japan. It is symbolized by ¥ and is subdivided into 100 sen. The exchange rate for JPY is currently {exchangeRates["JPY"]} per USD.");
                        break;
                    case 5:
                        converted = amount * exchangeRates["INR"];
                        Console.WriteLine($"Converted Amount: ₹ {converted}");
                        Console.WriteLine($"\nThe Indian Rupee (INR) is the official currency of India. It is symbolized by ₹ and is subdivided into 100 paise. The exchange rate for INR is currently {exchangeRates["INR"]} per USD.");
                        break;
                    case 6:
                        converted = amount * exchangeRates["CAD"];
                        Console.WriteLine($"Converted Amount: C$ {converted}");
                        Console.WriteLine($"\nThe Canadian Dollar (CAD) is the official currency of Canada. It is symbolized by C$ and is subdivided into 100 cents. The exchange rate for CAD is currently {exchangeRates["CAD"]} per USD.");
                        break;
                    case 7:
                        converted = amount * exchangeRates["AUD"];
                        Console.WriteLine($"Converted Amount: A$ {converted}");
                        Console.WriteLine($"\nThe Australian Dollar (AUD) is the official currency of Australia. It is symbolized by A$ and is subdivided into 100 cents. The exchange rate for AUD is currently {exchangeRates["AUD"]} per USD.");
                        break;
                    case 8:
                        converted = amount * exchangeRates["CNY"];
                        Console.WriteLine($"Converted Amount: CN¥ {converted}");
                        Console.WriteLine($"\nThe Chinese Yuan (CNY) is the official currency of China. It is symbolized by CN¥ and is subdivided into 100 fen. The exchange rate for CNY is currently {exchangeRates["CNY"]} per USD.");
                        break;
                    case 0:
                        ShowOptions();
                        break;
                    default:
                        def = 1;
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            } while (def == 1);

            Console.ReadKey();
        }
        public void ShowResults()
        {
            ShowDisplayResult();
            ShowLoadingAnimation();
            ShowConversionResult();
        }
        public void ShowExchangeRates()
        {
            x = 0;

            Console.Clear();
            Console.WriteLine("Current Exchange Rates (relative to USD):");
            Console.WriteLine("\nAvailable Currencies:\n");
            Console.WriteLine($"R$ {exchangeRates["BRL"]} - BRL - Brazilian Real");
            Console.WriteLine($"€ {exchangeRates["EUR"]} - EUR - Euro");
            Console.WriteLine($"£ {exchangeRates["GBP"]} - GBP - British Pound");
            Console.WriteLine($"¥ {exchangeRates["JPY"]} - JPY - Japanese Yen");
            Console.WriteLine($"₹ {exchangeRates["INR"]} - INR - Indian Rupee");
            Console.WriteLine($"C$ {exchangeRates["CAD"]} - CAD - Canadian Dollar");
            Console.WriteLine($"A$ {exchangeRates["AUD"]} - AUD - Australian Dollar");
            Console.WriteLine($"CN¥ {exchangeRates["CNY"]} - CNY - Chinese Yuan");
            Console.WriteLine("\n0. Back");
            x = Convert.ToInt32(Console.ReadLine());

            if (x != 0)
            {
                Console.WriteLine("Invalid option. Please try again.");
                Console.ReadKey();
                ShowExchangeRates();
            }
            else
            {
                ShowOptions();
            }
        }
    }
}
