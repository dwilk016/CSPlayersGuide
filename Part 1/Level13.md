# Level 13: Methods
## Defining a Method
consider the following
```cs
Console.WriteLine(Hello, World!");

void CountToTen()
{
  for (int current = 1; current <= 10; current++)
    Console.WriteLine(current);
}
```
`void CountToTen()` declares the method and establishes how to use it. 
`CountToTen` is the method name and uses UpperCamelCase.
`void` is the method return type. 
`()`, every method declaration inculdes a pair of parentheses which can include information for the method to use. 
`{ ... }` is the method body.

### Local Functions
A function is any reusable, callable code block. A function is also a method if it is a member of a class. Main
is a method, CountToTen is not. Fuctions that are defined inside other functions are local functions, so CountToTen is a
local function.

## Calling a Method
```cs
CountToTen();
CountToTen();

void CountToTen()
{
  for (int current = 1; current <= 10; current++)
    Console.WriteLine(current);
}
```

### Methods get their own variables
Methods have scope, so variables declared in a method can be used elsewhere. Functions can reach up, but this should only be used rarely because they are now sharing variables. If you
keep using variables from the containing method you can throw a static infront of the void and the compiler will throw an error. 

## Passing data to a method
You can pass a method a parameter (variable). 
```cs
Count(10);
Count(20);

void Count(int numberToCount)
{
  for (int current = 1; current <= numberToCount; current++)
    Console.WriteLine(current);
}
```
methods initialize these varables when the method is called. Variables we have been using so far are called local variables. The value provided in the method call is called the argument. 

### Multiple Parameters
```cs
Count(10, 20);

void Count(int start, int end)
{
  for (int current = start; current <= end; current++)
    Console.WriteLine(current);
}
```
You can pass a method multiple parameters. 

## Returning a value from a method
Parameters allow us to pass data to a method, return values allow methods to send data back. 
```cs
int ReadNumber()
{
  string input = Console.ReadLine();
  int number = Convert.ToInt32(input);
  return number;
}
```
First we indicate the data type, then we state the value to be returned. 

### Return Early
A method will return as soon as it encounters a return, regardless of if there is more code to execute. Think break for loops. If you declare a type you MUST return that type. 

### Multiple Return Values
Methods can only return a single value, but this isn't as limiting as it sounds. 

## Method Overloading
Methods allow you to overload them with multiple parameters. They use a process of overload resolution to determine which method to use. 
```cs
void Count(int numberToCount)
{
  for (int current = 1; current <= numberToCount; current++)
    Console.WriteLine(current);
}

void Count(int start, int end)
{
  for (int current = start; current <= end; current++)
    Console.WriteLine(current);
}
```
Note: Local functions cannot be overloaded. Only Methods. 

## Simple Methods with Expressions
```cs
int DoubleAndAddOne(int value)
{
  return value * 2 + 1;
}
```
This can be simplified as:
```cs
int DoubleAndAddOne(int value) => value * 2 + 1;
```

## XML Documentation Comments
```cs
/// <summary>
/// Counts to the given number, starting at 1 and including the number provided.
/// </summary>
void Count(int numberToCount)
{
  for (int current = 1; current <= numberToCount; current++)
    Console.WriteLine(current);
}
```
This is a useful way of documenting your code and good practice. 

## Challenge: Taking a Number 
```cs
int result = AskForInteger("What is the speed of an unladen swallow? ");
int rangeResult = AskForIntegerInRange("Pick a number between 1 and 100: ", 1, 100);

/// <summary>
/// This function takes a text and returns an integer.
/// </summary>
int AskForInteger(string text)
{
    Console.Write(text);
    
    while (true) 
    {
        string input = Console.ReadLine();

        if (int.TryParse(input, out result)) 
        {
            return result;
        }

        Console.Write("Please enter an Interger Value: ");
    }
}

/// <summary>
/// This function takes a text and returns only integer values in a specific range.
/// </summary>
int AskForIntegerInRange(string text, int min, int max)
{
    Console.Write(text);

    while (true)
    {
        string input = Console.ReadLine();

        if (int.TryParse(input, out result) && isIntegerInRange(result, min, max))
        {
            return result;
        }

        Console.Write($"Please enter an Interger Value between {min} and {max}: ");
    }
}

/// <summary>
/// This function checks to see if an integer is between two integers.
/// </summary>
bool isIntegerInRange (int value, int min, int max)
{
    bool inRange = (value >= min && value <= max);
    return inRange;
}
```

## The Basics of Recursion
A method can call other methods when needed, even itself. This is known as recursion. 
```cs
void RecursionMethod()
{
  RecursionMethod();
}
```
This code demonstrates the danger of recursion. This code will never stop executing until the computer runs out of memory. Recursion must have a way to stop. For example:
```cs
int Factorial(int number)
{
  if(number == 1) return 1;
  return number * Factorial(number - 1);
}
```
When we reach one the recursion will collapse and the program will stop executing. Lets run through this step by step for `number = 3`.

```cs
Console.WriteLine(Factorial(3));
//step 1: 3 is passed to Factorial
  if(3 == 1) return 1 // false
  return 3 * Factorial(2);

  //step 2: 2 is passed to Factorial, before the return!
  if(2 == 1) return 1 // false
  return 2 * Factorial(1);

  //step 3: 1 is passed to Factorial, before the second return!
  if(1 == 1) return 1; // true
  
  //step 4: the recursion now collapses.
  return 2 * 1; // 2

  //step 5:
  return 3 * 2;

//step 6: 
Console.WriteLine(6);
```
Recursion can be tricky and you need to exercise caution when using it. The big takeaway for now is that methods can all other methods, including themselves. 

## Challenge: Countdown
```cs
for (int index = 10; index > 0; index--)
{
    Console.WriteLine(index);
}

CountDown(10);

void CountDown(int number)
{
    if (number == 0) return;
    Console.WriteLine(number);
    CountDown(number - 1);
}
```
