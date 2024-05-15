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
