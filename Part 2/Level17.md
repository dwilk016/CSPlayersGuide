# Level 17: Tuples
Tuples are just a normal types that are bundled together as "one" type. 
## The basics of tuples
```cs
(string, int, int) score = ("R2-D2", 12420, 15);
```
This creates a tuple called `scores` with three values. A string, and two ints. 

You can also use `var` to make declaring tuples a little easier. 
```cs
var score = ("R2-D2", 12420, 15);
```
This does the same thing. 

To reference individual items from a tuple use `.item1` ... `.itemN`.
```cs
Console.WriteLine($"Name: {score.item1} Level: {score.item3} Score:{score.item3}");
```

Tuples are value types so thier equivilances are exact, but the tuples must be the same. 
```cs
(string, int, int) score1 = ("R2-D2", 12420, 15);
(string, int, int) score2 = score1;

(string, int) score3 = score1; // does not work
(int, int, string) score4 = score1; // also, does not work
```

## Tuple Element Names
Tuple elements can be named for easier reference and readability, but they are not actually part of the tuple. 
```cs
(string Name, int Points, int Level) score = ("R2-D2", 12420, 15);
Console.WriteLine($"Name: {score.Name} Level: {score.Level} Score:{score.Points}");

var score = (Name: "R2-D2", Points: 12420, Level: 15);
Console.WriteLine($"Name: {score.Name} Level: {score.Level} Score:{score.Points}");
```
You don't have to name every item, anything you don't explicitly name will use the regular `.itemN` nameing.

## Tuples and Methods
Tuples can be used for parameters and return values. 
```cs
var score = GetScore();
DisplayScore(score);

void DisplayScore((string Name, int Points, int Level) score)
{
  Console.WriteLine($"Name: {score.Name} Level: {score.Level} Score:{score.Points}");
}

(string Name, int Points, int Level) GetScore() => ("R2-D2", 12420, 15);
```

Just remember, the element names are not actually part of the tuple, they are just there for conveniance. 
```
(string One, int Two, int Three) score = GetScores();

(string N, int P, int L) GetScores() => ("R2-D2", 12420, 15);

void DisplayScore((string Name, int Points, int Level) score)
{
  Console.WriteLine($"Name: {score.Name} Level: {score.Level} Score:{score.Points}");
}
```
This is just as valid.

## Examples
```cs
(double x, double y) point = (2.0, 4.0);

var matrix = (M11: 1, M12: 0,
              M21: 0, M22: 1); // this is better as an array!!

(string Name, int Points, int Level)[] CreateHighScores()
{
  return new (string, int, int)[3]
  {
    ("R2-D2", 12420, 15),
    ("C-3P0",  8543,  9),
    ("GONK",     -1,  1)
  };
}
```

## Deconstruct Tuples
The simplest way to pull data from a tuple is to just use direct assignment.
```cs
(string Name, int Points, int Level) score = ("R2-D2", 12420, 15);

string playerName = score.Name;
int playerScore = score.Points;
int playerLevel = score.Level;
```

Another way to deconstruct or unpack is to use parantheses. 
```cs
string playerName;
int playerScore;
int playerLevel;

(playerName, playerScore, playerLevel) = score;
```
be careful because this looks alot like how you create a tuple, but we are actually deconstructing it here. You can do it all in one line too.
```cs
(string playerName, int playerScore, int playerLevel) = score;
```

This can be useful for swapping values around.
```cs
int x = 3;
int y = 6;

(x, y) = (y, x);
```

If you want to discard a piece of information use the `_` discard variable.
```cs
(string playerName, int playerScore, _) = score;
```
## Challenge: Simula's Soup
```cs
using System;
class HelloWorld {
  static void Main() {
    (SoupType, MainIngredient, Seasoning) userSoup;
    
    Console.Write("What type of soup do you want? ");
    string inputSoupType = Console.ReadLine();
    
    Console.Write("What Main Ingredient do you want? ");
    string inputMainIngredient = Console.ReadLine();
    
    Console.Write("What Seasoning do you want? ");
    string intputSeasoning = Console.ReadLine();
    
    // Finish this later... I am tired...
  }
}

enum SoupType
{
    Soup,
    Stew,
    Gumbo
}

enum MainIngredient
{
    Mushrooms,
    Chicken,
    Carrots,
    Potatos
}

enum Seasoning
{
    Spicy,
    Salty,
    Sweet
}
```


















