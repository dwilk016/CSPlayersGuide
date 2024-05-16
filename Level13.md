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
int result = AskForNumber("What is the speed of an unladen swallow? ");
result = AskForNumberInRange("What is the speed of an unladen swallow? ", 0, 100);

int AskForNumber(string text)
{
  Console.Write(text);
  string input = Console.ReadLine();
  return Convert.ToInt32(input);
}

int AskForNumberInRange(string text, int min, int max)
{
  Console.Write(text);
  do
  {
    string input = Console.ReadLine();
    int result = Convert.ToInt32(input);
  } while (result < min || result > max)
}
```
I'm too tired for this shit, I'll fix it later.... its broken.
