# Level 9: Decision Making
## The `IF` Statement

```csharp
string input = Console.ReadLine();
int score = Convert.ToInt32(input);

if  (score == 100)
  Console.WriteLine("A+! Perfect score!");
```

## Block Statement

```csharp
if (score == 100) {
  Console.WriteLine("A+!");
  Console.WriteLine("A Perfect score!");
}
```

## Blocks, Variables, and Scope
Variables created within a block can not be used outside that block. This is known as the scope of the variable. 

## The `ELSE` Statement
```csharp
string input = Console.ReadLine();
int score = Convert.ToInt32(input);

if  (score == 100)
  Console.WriteLine("A+! Perfect score!");
else
  Console.WriteLine("Try Again.");
```

## The `Else If` Statement
```csharp
string input = Console.ReadLine();
int score = Convert.ToInt32(input);

if  (score == 100)
  Console.WriteLine("A+! Perfect score!");
else if (score == 99)
  Console.WriteLine("Missed it by THAT much.");
else if (score == 42)
  Console.WriteLine("Oh no, not again!");
else
  Console.WriteLine("Try Again.");
```

## Relational Operators
- `==` is the equality operator
- `!=` is the inequality operator
- `<` is greater than
- `>` is less than
- `<=` is greater than or equal to
- `>=` is less than or equal to

## Using `bool` in decision making
```csharp
int score = 45;
int pointsNeededToPass = 100;

bool levelComplete;

if (score >= pointsNeededToPass)
  leveComplete = true;
else
  levelComplete = false;

if (levelComplete)
  Console.WriteLine("You've beaten the level!");

```

You can shorten this code:
```csharp
bool levelComplete = score >= pointsNeededToPass;
```

## Challenge: Repair the Clocktower
```csharp
string input = Console.ReadLine();
int time = Covert.ToInt32(input);

if (time % 2 == 0)
  Console.WriteLine("Tick");
else
  Console.WriteLine("Tock");
```

## Logical Operators
There are two logical operators
- `&&` and: both must be ture for true
- `||` or: one must be true for true

## Nesting `if` Statements
```csharp
if (true) {
  if (false) {
    Console.WriteLine("HI");
  } else {
    Console.WriteLine("GOODBYE");
  }
} else {
  Console.WriteLine("Error");
}
```

## Conditional Operator

`condition expression ? expression if true : expression if false;`

this is called the conditional operator and it works similar to an `if` statement.

```csharp
string displayText = score > highscore ? "New High Score!" : "Try Again";
Console.WriteLine(displayText);
```

it should only be used when simple expressions are needed. 

## Challenge: Watchtower
```csharp
Console.Write("x: ");
string input = Console.ReadLine();
int x = Convert.ToInt32(input);

Console.Write("y: ");
input = Console.ReadLine();
int y = Convert.ToInt32(input);

if (x > 0) {
  if (y > 0) Console.WriteLine("NE");
  if (y == 0) Console.WriteLine("E");
  if (y < 0) Console.WriteLine("SE");
}
if (x == 0) {
  if (y > 0) Console.WriteLine("N");
  if (y == 0) Console.WriteLine("!");
  if (y < 0) Console.WriteLine("S");
}
if (x < 0) {
  if (y > 0) Console.WriteLine("NW");
  if (y == 0) Console.WriteLine("W");
  if (y < 0) Console.WriteLine("SW");
}
```
