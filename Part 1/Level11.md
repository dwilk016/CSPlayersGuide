# Level 11: Looping
There are three types of loops in this level
- `while (condition) { ... }`
- `do { ... } while (condition)`
- `for (initialization; condition; update) { ... }`

## The `while` loop
```csharp
while (ture) {
    // This code repeats as long as condition is true.
}
```
In the while loop the condition is evaluated first, if it is false we skip past the loop. The loop condition is only evaluated at the start of the loop. 

Example: This code asks the user to enter a number between 0-10 if they do not it repeats until the do. 
```csharp
int playersNumber = -1;

while (playersNumber < 0 || playersNumber > 10) {
    Console.WriteLine("Enter a number between 0 and 10.");
    string playerResponse = Console.ReadLine();
    playersNumber = Convert.ToInt32(playersResponse);
}
```

## The `do/while` loop
The do/while loop evaluates it's condition at the end of the loop, instead of at the begggining. 
```csharp
int playersNumber;

do {
    Console.WriteLine("Enter a number between 0 and 10.");
    string playerResponse = Console.ReadLine();
    playersNumber = Convert.ToInt32(playersResponse);
} while (playersNumber < 0 || playersNumber > 10);
```
We do not need to initialize `playersNumber` outside the loop becasue the loop will always run at least once. Variables declared inside a loop are only avalible inside the loop, so `playerResponse` in not avalible outside the loop. Also, note the `;` at the end, it is required. 

## The `for` loop
Consider the `while` loop:
```csharp
int x = 1;
while (x <= 5) {
    Console.WriteLine(x);
    x++;
}
```
This can be rewritten as a `for` loop:
```csharp
for (int x = 1; x <= 5; x++) {
    Console.WriteLine(x);
}
```
The first part initializes the `x` variable inside the `for` loop (remember scope). The second part, like a while loop, is only evaluated at the start of each loop. So if it is false from the start then the loop never runs. The third part, defines how to change the variable each loop. Any part of the `for` loop can be omitted as needed, so `for (;;) { ... }` is the same as `while (true)`.

## `break` out of loops and `continue` to the next pass
`break` and `continue` statements control how a loop is handled. 
- `break` forces the loop to end, the condition is NOT reevaluated.  
- `continue` forces the loop to restart, the condition IS reevaluated.

consider the following example:
```csharp
while (true) {
    Console.Write("Thing of a number and type it here: ");
    string input = Console.ReadLine();

    if (input == "quit" || input == "exit") 
        break;
    
    int number = Convert.ToInt32(input);

    if (number == 22) {
        Console.WriteLine("I don't like that number. Pick another one.");
        continue;
    }
    Console.WriteLine($"I like {number}. It's the one before {number + 1}!");
}
```

This loop will not terminate until you type `quit` or `exit`. If the `number = 22` then the program will not evalute the rest of the loop and return to the start. 

## Nested Loops
You can nest loops inside one another. 

Example 1: 
```csharp
for (int a = 1; a <= 10; a++) {
    for (int b = 1; b <= 10; b++) {
        Console.WriteLine($"{a} * {b} = {a * b}");
    }
}
```
This displays the multiplication tables from 1 - 10.

Example 2:
```csharp
int totalRows = 5;
int totalColumns = 5;

for (int currentRow = 1; currentRow <= totalRows; currentRow++) {
    for (int currentColumn = 1; currentColumn <= totalColumns; currentColumn++) {
        Console.Write("*");
    }
    Console.WriteLine();
}
```
This program creates a grid of `*`. 

## Challenge: The Prototype
```cs
Console.WriteLine("======================================");
Console.WriteLine("=                                    =");
Console.WriteLine("=           The Prototype            =");
Console.WriteLine("=                                    =");
Console.WriteLine("======================================");
Console.WriteLine();

Console.Write("User1, enter a number between 0 and 100: ");
string input = Console.ReadLine();
int number = Convert.ToInt32(input);

while (number < 0 || number > 100)
{
    Console.Write("Please enter a number between 1 and 100: ");
    input = Console.ReadLine();
    number = Convert.ToInt32(input);
}

Console.Clear();

Console.Write("User 2, guess a number: ");
input = Console.ReadLine();
int guess = Convert.ToInt32(input);

while (guess != number)
{
    if (number > guess) Console.Write($"{guess} is too Low! Guess again: ");
    if (number < guess) Console.Write($"{guess} is too High! Guess again: ");

    input = Console.ReadLine();
    guess = Convert.ToInt32(input);
}

if (guess == number) Console.WriteLine("You guessed the number!");

Console.WriteLine();
Console.WriteLine("Press any key to exit.");
Console.ReadKey(true);
```

## Challenge: The Magic Cannon
```cs
Console.WriteLine("======================================");
Console.WriteLine("=                                    =");
Console.WriteLine("=          The Magic Cannon          =");
Console.WriteLine("=                                    =");
Console.WriteLine("======================================");
Console.WriteLine();

for (int i = 1; i <= 100; i++)
{
    bool isFire = i % 3 == 0;
    bool isElectric = i % 7 == 0;

    if (isFire && isElectric)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i}: Magic Blast");
    }
    else if (isFire)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire Blast");
    }
    else if (isElectric)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric Blast");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{i}: Normal Blast");
    }
}
```