using System;
using System.Collections.Generic;

MyCalculator calculator = new("Welcome to this calculator!");
calculator.Start();

public sealed class MyCalculator
{
    private readonly string _greeting;

    private readonly Dictionary<string, string> _operators = new()
    {
        { "+", "Add" },
        { "-", "Subtract" },
        { "*", "Multiply" },
        { "/", "Divide" }
    };

    public MyCalculator(string greeting)
    {
        _greeting = greeting;
    }

    public void Start()
    {
        Console.WriteLine(_greeting);
        Console.WriteLine("Type 'exit' anytime to quit.");
        // Where the whole equation is done
        while (true)
        {
            string operatorChoice = GetOperatorChoice();
            if (operatorChoice == "exit") break;

            int firstNumber = GetIntegerInput("Enter the first integer:");
            int secondNumber = GetIntegerInput("Enter the second integer:");

            int? result = PerformCalculation(operatorChoice, firstNumber, secondNumber);
            if (result.HasValue)
            {
                Console.WriteLine($"The result is: {result.Value}");
            }

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }

    //select the operator you want
    private string GetOperatorChoice()
    {
        while (true)
        {
            Console.WriteLine("\nChoose from the following operators:");
            foreach (var op in _operators)
            {
                Console.WriteLine($"{op.Value}: {op.Key}");
            }

            Console.Write("Enter an operator: ");
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
                return "exit";

            if (_operators.ContainsKey(input))
                return input;

            Console.WriteLine("Invalid operator choice. Try again.");
        }
    }

//Select numbers
    private int GetIntegerInput(string prompt)
    {
        while (true)
        {
            Console.WriteLine(prompt);
            string input = Console.ReadLine().Trim();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting calculator...");
                Environment.Exit(0);
            }

            if (int.TryParse(input, out int number))
                return number;

            Console.WriteLine($"'{input}' is not a valid integer. Try again.");
        }
    }

//Perfom the math of both the numbers and intergers
    private int? PerformCalculation(string operatorChoice, int firstNumber, int secondNumber)
    {
        try
        {
            return operatorChoice switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                //checks for 0 
                "/" => secondNumber == 0 ? throw new DivideByZeroException() : firstNumber / secondNumber,
                _ => throw new NotSupportedException($"Operator '{operatorChoice}' is not supported.")
            };
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: You cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return null;
    }
}
