# C# Object-Oriented Calculator

## Overview
This project is a simple calculator built in C# that helped me deepen my understanding of Object-Oriented Programming (OOP). I wanted to focus on structuring my code using classes, encapsulation, and exception handling to create a more maintainable and scalable application.

## Features
- Supports basic arithmetic operations: Addition, Subtraction, Multiplication, and Division.
- Uses a dictionary to map operators to their respective operations.
- Implements exception handling to prevent errors such as division by zero.
- Uses a loop to continuously accept user input until the user decides to exit.
- Encourages clean code principles, including encapsulation and immutability where necessary.

## How It Works
1. The program starts by displaying a welcome message.
2. The user selects an arithmetic operation from the available options.
3. The user inputs two integers.
4. The program performs the chosen operation and displays the result.
5. The user can continue performing calculations or type 'exit' to quit.

## Code Structure
The project is structured around a single class:

### `MyCalculator`
- **Fields:**
  - `_greeting`: Stores the welcome message.
  - `_operators`: A dictionary mapping operator symbols to their corresponding names.
- **Methods:**
  - `Start()`: Runs the main program loop.
  - `GetOperatorChoice()`: Handles user selection of an arithmetic operator.
  - `GetIntegerInput(prompt)`: Ensures valid integer input from the user.
  - `PerformCalculation(operatorChoice, firstNumber, secondNumber)`: Performs the requested calculation and includes error handling for division by zero.

## Key OOP Concepts Applied
- **Encapsulation**: All fields are private, and operations are handled internally within methods.
- **Abstraction**: The details of input validation and calculations are abstracted within the class methods.
- **Immutability**: The dictionary storing operator mappings remains read-only after initialization.
- **Exception Handling**: The program gracefully handles division by zero and invalid input cases.

## Running the Program
To run this calculator, ensure you have .NET installed and execute the following command in your terminal:

```sh
 dotnet run
```

## Future Improvements
- Add support for floating-point numbers.
- Implement additional mathematical functions (e.g., exponentiation, modulus).
- Introduce a graphical user interface (GUI) for better usability.

---
This project was a great learning experience in reinforcing OOP principles in C#, and I'm excited to expand upon it further!

