using System;

namespace PI_nach_Wallis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zur Berechnung von PI nach Wallis");


            double i = 1; //declaration of the variables
            double comp = Math.Pow(10, -12); //comp = compare Value
            double oValue; //oValue = old Value
            double nValue = (1 + (1 / (4 * i * i - 1))); //nValue = new Value
            double diff; //dif = difference Value

            do //calculate PI
            {
                i++;
                oValue = nValue;
                nValue = nValue * (1 + (1 / (4 * i * i - 1)));
                diff = nValue - oValue;

            }
            while (diff > comp); //calculating till the difference is greater than 10^-12
            {

            }
            Console.WriteLine("\nPi= " + 2 * nValue); //output of the solution
            Console.WriteLine("\n---------------------------------------------------------------------------------------------");
            Console.WriteLine("Hinweis:"); //giving a hint
            Console.WriteLine("\nDa nicht alle Werte (welche unendlich viele wären) berechnet werden können, wird ab einer" +
                "\ngewissen Nachkommastelle die Zahl PI verfälscht");
            Console.WriteLine("Für weitere Informationen zur Berechnung nach Wallis"
                + "\nfolgen Sie bittem folgendem Link:");
            Console.WriteLine("https://de.wikipedia.org/wiki/Wallissches_Produkt");

        }
    }
}
