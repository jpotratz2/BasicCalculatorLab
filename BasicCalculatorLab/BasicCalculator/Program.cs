using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter the Temperature in Farenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int temperature = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Relative Humidity");
            int RelativeHumidity = int.Parse(Console.ReadLine());
       
            int DewPoint = temperature - 9 * (100 - RelativeHumidity) / 25;

            Console.WriteLine("The dew point is " + DewPoint);

            Console.WriteLine("Enter the Wind Speed");
            int WindSpeed = int.Parse(Console.ReadLine());

            double WindChill = 35.74
                + (0.6125 * temperature)
                - 35.75 * Math.Pow(WindSpeed, 0.16)
                + 0.4275 * temperature * Math.Pow(WindSpeed, 0.16);

            Console.WriteLine("The Wind Chill is " + WindChill);
        }
    }
}
