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


