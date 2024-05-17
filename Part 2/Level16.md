# Level 16: Enumerations
Enumerations or Enumeration Types is a small list of possible options.

```cs
Console.WriteLine("Hello, World!");

enum Season { Winter, Spring, Summer, Fall }
```

Enumerations must go at the end of your program, or in a seperate file alltogther. Convention also states that you should use UpperCamelCase when naming them.

## Using Enumerations
Once you have created an Enumeration you can use it like anyother type. 

```cs
Season current = Season.Summer;

if (current == Season.Summer || current == Season.Winter )
  Console.WriteLine("Happy Solstice!");
else
  Console.WriteLine("Happy Equinox!");
```

## Challenge: Simula's Test
```cs
State boxState = State.Locked;
	
while (true)
{
  Console.Write($"The box is {boxState}. What do you want to do? ");
	string input = Console.ReadLine();
	    
  if (input == "exit" || input == "quit") break;
  if (boxState == State.Locked)
  {
    if (input == "unlock") boxState = State.Closed;
  }
  if (boxState == State.Closed)
  {
    if (input == "lock") boxState = State.Locked;
    if (input == "open") boxState = State.Open;
  }
  if (boxState == State.Open)
  {
    if (input == "close") boxState = State.Closed;
  }
}

enum State
{
  Locked,
  Closed,
  Open
}
```

## Underlying Type
The secret to Enums is that they are jsut int types, but they can be forced to other integer types
```cs
enum Season : byte { ... }
```
This forces the values to be of byte type.

The first value is the default and = 0, they increment by 1 from there, but you can force them to have a value too.
```cs
enum Season { Winter = 3, Spring = 6, Summer = 9, Fall = 12 }
```
There does not have to be a default value, but be careful as you will need to make sure all your bases are covered. 

You can also cast enums from one type to another.
```cs
int number = (int)Season.Fall;
Season now = (Season)3;
```
Just be careful, if you cast to a value that doesn't exist you will get an error. 
