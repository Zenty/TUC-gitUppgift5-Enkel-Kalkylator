using System;
using System.Numerics;

namespace EnkelKalkylator;

// Creating class onStartUp to display & take user input.
public class onStartUp
{
    public myUserInput initiate()
    {
        Console.WriteLine("Enkel Kalkylator");
        Console.WriteLine("Ange operation (+, -, *, /): ");
        char input_operation = Console.ReadKey().KeyChar;
        Console.WriteLine("\nAnge första talet: ");
        double input_num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ange andra talet: ");
        double input_num2 = Convert.ToDouble(Console.ReadLine());

        // I create a new instance of myUserInput and return the object containing all input data.
        return new myUserInput(input_operation, input_num1, input_num2);
    }
}

// Creating class myUserInput to keep track of my numbers using objects.
public class myUserInput
{
    public char Operation { get; set; }
    public double Num1 { get; set; }
    public double Num2 { get; set; }

    public myUserInput(char operation, double num1, double num2)
    {
        Operation = operation;
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
        // I Create a list for my objects containing user input.
        List<myUserInput> userInput = new List<myUserInput>();

        // I Create a new instance of my onStartUp class
        onStartUp onStartUp = new onStartUp();
        userInput.Add(onStartUp.initiate()); // I run the .initiate() method that takes all user input and return a new myUserInput object that I add to my list.

        double result = 0;
        switch (userInput[0].Operation)
        {
            case '+':
                result = new myCalculations().Addition(userInput[0].Num1, userInput[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                break;
            case '-':
                result = new myCalculations().Substraction(userInput[0].Num1, userInput[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                break;
            case '*':
                result = new myCalculations().Multiplication(userInput[0].Num1, userInput[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                break;
            case '/':
                result = new myCalculations().Division(userInput[0].Num1, userInput[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                break;
            default:
                Console.WriteLine("Ogiltig operation.");
                return;
        }

        Console.WriteLine($"Resultat: {result}"); // Write out the result
        Console.ReadKey();
    }
}