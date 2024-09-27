using System;
using System.Numerics;

namespace EnkelKalkylator;

// Creating class myNumbers to keep track of my numbers using objects.
public class myNumbers
{
    public double Num1 { get; set; }
    public double Num2 { get; set; }

    public myNumbers(double num1, double num2)
    {
        Num1 = num1;
        Num2 = num2;
    }
}
// Creating class myCalculations to create reusable methods for addition, substraction, multiplication & division.
public class myCalculations
{
    public double Addition(double num1, double num2) // My method for calculating addition.
    {
        return num1 + num2;
    }

    public double Substraction(double num1, double num2) // My method for calculating substraction.
    {
        return num1 - num2;
    }
    public double Multiplication(double num1, double num2) // My method for calculating multiplication.
    {
        return num1 * num2;
    }
    public double Division(double num1, double num2) // My method for calculating division.
    {
        return num1 / num2;
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
                result = new myCalculations().Addition(numbersList[0].Num1, numbersList[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                break;
            case '-':
                result = new myCalculations().Substraction(numbersList[0].Num1, numbersList[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                break;
            case '*':
                result = new myCalculations().Multiplication(numbersList[0].Num1, numbersList[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                break;
            case '/':
                result = new myCalculations().Division(numbersList[0].Num1, numbersList[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                break;
            default:
                Console.WriteLine("Ogiltig operation.");
                return;
        }

        Console.WriteLine($"Resultat: {result}");
        Console.ReadKey();
    }
}