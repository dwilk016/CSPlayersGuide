# Level 4: Comments

```csharp
// this is a comment it can be placed on its own line or at the end of a statement.

Console.WriteLine("There is a comment at the end of this statement."); // Comment Here

/* Inline comments can be placed anywhere */

Console.WriteLine("Hello, " + /* Inline Comment */ name);
```

## Challenge: The Thing Namer 3000 (100 XP)
```csharp
Console.WriteLine("What kind of thing are we talking about?");
string a = Console.ReadLine(); // a is the name of the object
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string b = Console.ReadLine(); // b is an adjective
string c = "of Doom";
string d = "3000";
Console.WriteLine($"The {b} {a} {c} {d}!"); //Example: The Big Axe of Doom 3000
```

To make this code more readable you could use better variable names. remember to be decriptive and not to use abreviasions. 

```csharp
Console.WriteLine("What kind of thing are we talking about?");
string object = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
string adjective = Console.ReadLine();
string ofDoom = "of Doom";
string iteration = "3000";
Console.WriteLine($"The {object} {adjective} {ofDoom} {iteration}!"); //Example: The Big Axe of Doom 3000
```

You should alway comment your code as you write it. You will not remember what something does a week
from now. Be careful about commenting too much (you don't want to read a novel) or too little (you 
still need to know what the code does).

