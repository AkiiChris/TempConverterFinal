using System;

namespace TempConverterFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 < 2)
            {


                Console.WriteLine("Welcome to the Temperature Converter!");

                Console.Write("What is the temperature?");
                string num = Console.ReadLine();
                decimal inputNumber = decimal.Parse(num);


                Console.Write("What unit is that? (F = Fahrenheit, C = Celsius)");
                string userInput = Console.ReadLine();

                if (userInput[0] == 'C' || userInput[0] == 'c') 
                {
                    CelsiusToFahrenheit(inputNumber);
                }
                else if (userInput[0] == 'F' || userInput[0] == 'f')
                {
                    FahrenheitToCelsius(inputNumber);
                }

                Console.WriteLine("Would you like to convert another temperature? (Y / N)");
                string userInput2 = Console.ReadLine();

                if (userInput2 == "Y" || userInput2 == "y")
                {
                    continue;

                }
                else
                {
                    break;
                }
            }
        }

        static void FahrenheitToCelsius(decimal inputNumber)
        {
            decimal fahrenheitToC;

            fahrenheitToC = Math.Round((inputNumber - 32) * .55555555555m, 1);
            Console.WriteLine($"{inputNumber} degrees Fahrenheit is {fahrenheitToC} degrees Celsius.");
            if (fahrenheitToC > 26.7m)
            {
                Console.WriteLine("That's really warm!");
            }
        }

        static void CelsiusToFahrenheit(decimal inputNumber)
        {
            decimal celsiusToF;

            celsiusToF = Math.Round((inputNumber * 1.8m) + 32, 1);
            Console.WriteLine($"{inputNumber} degrees Celsius is {celsiusToF} degrees Fahrenheit.");
            if (celsiusToF > 80)
            {
                Console.WriteLine("That's really warm!");
            }

        }
    
    }
}
