using System.ComponentModel;

Console.WriteLine("======================");
Console.WriteLine("C# CONSOLE CALCULATOR");
Console.WriteLine("======================");

while (true)
{
   Console.WriteLine();
   Console.WriteLine("1. Add");
   Console.WriteLine("2. Subtract");
   Console.WriteLine("3. Multiply");
   Console.WriteLine("4. Divide");
   Console.WriteLine("5. Quit");

   Console.Write("Choose an operation");
   string? choice = Console.ReadLine();

   if (choice == "5")
   {
    Console.WriteLine("Goodbye!");
    break;
   }

   if (
    choice != "1" &&
    choice != "2" &&
    choice != "3" &&
    choice != "4" 
   )

   {
    Console.WriteLine("Invalid choice. Please select 1-5. ");
    continue;
   }

   decimal firstNumber = GetNumber("Enter first number: ");
   decimal secondNumber = GetNumber("Enter second number: ");

   decimal result;

   if (choice == "1")
  {
    result = Add(firstNumber, secondNumber);
  }
   else if (choice == "2")
  {
    result = Substract(firstNumber, secondNumber);
  }
   else if (choice == "3")
  {
    result = Multiply(firstNumber, secondNumber);
  }
   else
  {
    if (secondNumber == 0)
    {
      Console.WriteLine("Cannot divide by zero.");
      continue;
    }
    result = Divide(firstNumber, secondNumber);
  }
  Console.WriteLine($"Result: {result:F2}");
}

static decimal Add (decimal firstNumber, decimal secondNumber)
{
  return firstNumber + secondNumber;
}

static decimal Substract (decimal firstNumber, decimal secondNumber)
{
  return firstNumber - secondNumber;
}

static decimal Multiply (decimal firstNumber, decimal secondNumber)
{
  return firstNumber * secondNumber;
}

static decimal Divide (decimal firstNumber, decimal secondNumber)
{
  return firstNumber / secondNumber;
}

static decimal GetNumber(string message)
{
  while(true)
  {
    Console.Write(message);
    if (decimal.TryParse(Console.ReadLine(), out decimal number))
    {
      return number;
    }
    Console.WriteLine("Invalid number. Please enter a valid number.");
  }
}