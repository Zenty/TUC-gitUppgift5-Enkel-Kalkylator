using System;
using System.Numerics;

namespace EnkelKalkylator;

// Creating class onStartUp to display & take user input.
public class onStartUp
{
    public myUserInput initiate()
    {
        Console.WriteLine("Enkel Kalkylator");
        Console.WriteLine("Ange operation (+, -, *, /, s): "); // I'm using 'S' instead of '^' since ReadKey().KeyChar gets set with the wrong char.
        char input_operation = Console.ReadKey().KeyChar;
        Console.WriteLine("\nAnge ditt tal: ");
        double input_num1 = Convert.ToDouble(Console.ReadLine());
        double input_num2 = 0;

        // We only need to work with one number if we're calculating the square root of a number.
        if (input_operation != 's')
        {
            Console.WriteLine("Ange ditt andra tal: ");
            input_num2 = Convert.ToDouble(Console.ReadLine());
        }

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

    public double Squareroot(double num1) // My method for calculating the squareroot
    {
        return Math.Sqrt(num1);
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

        double calcResult = 0;
        string resultString = "";
        switch (userInput[0].Operation)
        {
            case '+':
                calcResult = new myCalculations().Addition(userInput[0].Num1, userInput[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                resultString = $"Result: {userInput[0].Num1} {userInput[0].Operation} {userInput[0].Num2} = {calcResult}";
                break;
            case '-':
                calcResult = new myCalculations().Substraction(userInput[0].Num1, userInput[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                resultString = $"Result: {userInput[0].Num1} {userInput[0].Operation} {userInput[0].Num2} = {calcResult}";
                break;
            case '*':
                calcResult = new myCalculations().Multiplication(userInput[0].Num1, userInput[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                resultString = $"Result: {userInput[0].Num1} {userInput[0].Operation} {userInput[0].Num2} = {calcResult}";
                break;
            case '/':
                calcResult = new myCalculations().Division(userInput[0].Num1, userInput[0].Num2); // I Send the numbers stored in my List as data to my calculation.
                resultString = $"Result: {userInput[0].Num1} {userInput[0].Operation} {userInput[0].Num2} = {calcResult}";
                break;
            case 's':
                calcResult = new myCalculations().Squareroot(userInput[0].Num1); // I send the number stored in my List as data to my calculation.
                resultString = $"The Square root of {userInput[0].Num1} is: {calcResult}";
                break;
            default:
                Console.WriteLine("Ogiltig operation.");
                return;
        }

        Console.WriteLine(resultString); // Write out the result
        Console.ReadKey();
    }
}