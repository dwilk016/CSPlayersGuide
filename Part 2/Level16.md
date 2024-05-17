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
