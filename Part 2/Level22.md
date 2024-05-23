# Level 22: Null References

# Level 22: Null References

Reference type variables and fields, like strings and arrays, usually point to something on the Head instead of holding the data directly, When they do not there is a special value called a null reference. You can indicate a null referecne with the `null` keyword.
```cs
string name = null;
```
null is the default value for a referecne type. 

## Null or Not
For reference type variable stop and thing if null should be a value. If you want to allow null add a `?` to the end of the type. This explicitly states that you want to allow null types.
```cs
string? name = Console.ReadLine();
Arrow? arrow = new Arrow();
Rectangle? rectangle = new Reactangle();
```

## Disabling Nullable Type Warnings
You can disable null checking in the compiler, but this is not recommeneded. 

## Checking for NULL
Checking for NULL is quite easy
```cs
string? name = Console.ReadLine();
if (name != null)
{
    Console.WriteLine("The name is not NULL!");
}
```

## Null-Conditional Operators `?.` and `?[]`
```cs
private string? GetTopPlayerName()
{
    return _scoreManager.GetScores()[0].Name;
}
here `_scoreManager` could be null, `GetScores()` could return null, or the array could contain a null reference at index 0. To check for all of this our code becomes:

```cs
private string? GetTopPlayerScore()
{
    if (_scoreManager == null) return null;

    Score[]? scores = _scoreManager.GetScores();
    if (scores == null) return null;

    Scores? topScore = scores[0];
    if (topScore == null) return null;

    return topScore.Name;
}

The null check makes this code hard to understand and increases complexitiy. We can use the Null conditional operators to simplify.

```cs
private string? GetTopPlayerName()
{
    return _scoreManager?.GetScores()?[0]?.Name;
}
the `?.` and `?[]` evaluate the part before and if it is null, then they do not execute further and simply return null.

## The NULL coalescing Operator `??`
The null coalescing operator `??` checks if something is null and provides an alternative if it is.
```cs
private string? GetTopPlayerName()
{
    return _scoreManager?.GetScores()?[0]?.Name ?? "Not Found";
}
```
If the code before the `??` is null then the values after is assigned. 

## The Null-Forgiving Operator: `!`
Sometimes the compiler will throw a warning for a null value, even when a null value is imposible. for example a method that can return null but has your code will never allow that. The compiler might see this as a problem but in reality its not. You can use the null-forgiving operator to remove the warning. 
```cs
string message = MightReturnNullifNegative(10)!;
```

You place `!` at the end of an expression to let the compiler know that it will not be null.



