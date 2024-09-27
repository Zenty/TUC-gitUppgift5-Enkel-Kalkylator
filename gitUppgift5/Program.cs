using System;

namespace EnkelKalkylator
{
    // Creating class myNumbers to keep track of my numbers using objects.
    class myNumbers
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }

        // Adding a constructor
        public myNumbers(double num1, double num2)
        {
            Num1 = num1;
            Num2 = num2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // I Create a list for my objects containing numbers based on user input.
            List<myNumbers> numbersList = new List<myNumbers>();

            // Take in user input
            Console.WriteLine("Enkel Kalkylator");
            Console.WriteLine("Ange operation (+, -, *, /): ");
            char operation = Console.ReadKey().KeyChar;
            Console.WriteLine("\nAnge första talet: ");
            double input_num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ange andra talet: ");
            double input_num2 = Convert.ToDouble(Console.ReadLine());
            numbersList.Add(new myNumbers(input_num1, input_num2)); // I add my numbers to my List as an object.

            double result = 0;
            switch (operation)
            {
                case '+':
                    result = numbersList[0].Num1 + numbersList[0].Num2;
                    break;
                case '-':
                    result = numbersList[0].Num1 - numbersList[0].Num2;
                    break;
                case '*':
                    result = numbersList[0].Num1 * numbersList[0].Num2;
                    break;
                case '/':
                    result = numbersList[0].Num1 / numbersList[0].Num2;
                    break;
                default:
                    Console.WriteLine("Ogiltig operation.");
                    return;
            }

            Console.WriteLine($"Resultat: {result}");
            Console.ReadKey();
        }
    }
}