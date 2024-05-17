# Level 10: Switches
There are two types of switchs, a switch statement and a switch expression

## Switch Statements
Consider the example:

```
Avast, matey! What be ye desire?
1 - Rest
2 - Pillage the port
3 - Set sail
4 - Release the Kraken
What be the plan, Captain?
```

### If based solution
```csharp
if (choice == 1)
    Console.WriteLine("Ye rest and recover your health.");
if (choice == 2)
    Console.WriteLine("Raiding the port town get ye 50 gold.");
if (choice == 3)
    Console.WriteLine("The wind is a your back; the open horizon ahead.");
if (choice == 4)
    Console.WriteLine("'Tis but a baby kraken, but still eats toy boats.");
else
    Console.WriteLine("Apologies. I don't know that one.");
```

### Switch based solution
```csharp
Switch (choice) {
    case 1:
        Console.WriteLine("Ye rest and recover your health.");
        break;
    case 2:
        Console.WriteLine("Raiding the port town get ye 50 gold.");
        break;
    case 3:
        Console.WriteLine("The wind is a your back; the open horizon ahead.");
        break;
    case 4:
        Console.WriteLine("'Tis but a baby kraken, but still eats toy boats.");
        break;
    default:
        Console.WriteLine("Apologies. I don't know that one.");
        break;
}
```

`default` is optional and can go anywhere in the list, but it is good convention to place it at the end. 

`break` signifies the end of a case and will exit the switch. If you exclude the `break` you can have multiple cases evaluate for a single case. 

Example:
```csharp
case 1: 
case 2: 
    Console.WriteLine("That's a good choice!");
    break;
```

This switch would evaluate both case 1 and 2 if case 1 was selected. 

## Switch Expressions
Switches also come in an expression format
```csharp
string response;

response = choice switch {
    1 => "Ye rest and recover your health.",
    2 => "Raiding the port town get ye 50 gold.",
    3 => "The wind is a your back; the open horizon ahead.",
    4 => "'Tis but a baby kraken, but still eats toy boats.",
    _ => "Apologies. I don't know that one."
};

Console.WriteLine(response);
```

In a switch expression the target comes before the `switch` keyword instead of after. `case` is replaced by `=>` and the need for `break` is gone because each case can only have one expression. Also, note that each case is seperated by a `,`. 

In a switch expression the switch must evaluate to something or the program will crash. 

## Challenge: Buying Inventory
```csharp
Console.Write(
@"The following items are avalible:
    1 - Rope
    2 - Torches
    3 - Climbing Equipment
    4 - Clean Water
    5 - Machete
    6 - Canoe
    7 - Food Supplies
What item do you want to see the price of? "
);

string input = Console.ReadLine();
int choice = Convert.ToInt32(input);
string costStatement;

costStatement = choice switch
{
    1 => "Rope costs 10g.",
    2 => "Torches costs 15g.",
    3 => "Climbing Equipment costs 25g.",
    4 => "Clean Water costs 1g.",
    5 => "The Machete costs 20g.",
    6 => "The Canoe costs 200g.",
    7 => "Food Supplies cost 1g.",
    _ => "Sorry, I don't thing we have that."
};

Console.WriteLine(costStatement);
```

## Challenge: Discount Inventory
```csharp
Console.Write(
@"The following items are avalible:
    1 - Rope
    2 - Torches
    3 - Climbing Equipment
    4 - Clean Water
    5 - Machete
    6 - Canoe
    7 - Food Supplies
What item do you want to see the price of? "
);

string input = Console.ReadLine();
int choice = Convert.ToInt32(input);
double costOfItem;
string ItemName;

costOfItem = choice switch
{
    1 => 10,
    2 => 15,
    3 => 25,
    4 => 1,
    5 => 20,
    6 => 200,
    7 => 1,
    _ => 0
};

ItemName = choice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "Machete",
    6 => "Canoe",
    7 => "Food Supplies",
    _ => ""
};

Console.Write("Tell me what is your name? ");
string customerName = Console.ReadLine();

if (customerName == "David") costOfItem = costOfItem * 0.5;

Console.WriteLine($"{customerName}, The {ItemName} will be {costOfItem}g");
```