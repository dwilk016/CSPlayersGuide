// Level 7: Math

/*
# Operators and Operations 
There are binary operators (+, -, *, /, %, ^)
There are unary operators (++, --)
There is a ternary operator  (variable = (condition) ? expressionTrue :  expressionFalse;) - shorthand if...else

Addition, Subtraction, Multiplication, Division work exactly like you think they do. 
5 + 5 = 10
10 - 5 = 5
2 * 4 = 8
8 / 2 = 4

# Compound Expressions and Order of Operations
You can use multiple operators in a single expression. 

Order of Operations
  Multiplication and Division are done first, left to right.
  Addition and Subtraction are done second, left to right.

  2 + 5 * 2 = 12 NOT 14

  If you are worried or don't know, just use parentheses. 
*/

// Challenge: The Triangle Farmer (100 XP)
Console.Write("Enter the Base: ");
double length = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the Height: ");
double height = Convert.ToDouble(Console.ReadLine());
double area = (length * height) / 2;
Console.Write($"The area of a triangle with base {length} and height {height} is {area}");
// Rewrite this later. Base is a keyword and I need to figure out how to read a double from ReadLine().

/*
Notes:
# Special Numbers
MinValue and MaxValue allow you to assign a types largest or smallest value.

int Big = int.MaxValue;
short NegBig = short.MinValue;

double and float have a positive and negative infinity
double infinity = double.PositiveInfinity;

There is also a "not a number" NaN value

double notANumber = double.NaN;

# Interger vs Floating Division

int a = 5;
int b = 2;
int result = a / b; // result: 2

double a = 5;
double b = 2;
double result = a / b; //result: 2.5

If you want integer division, use integers. If you want floating division, use doubles. 

# Division by Zero
If you divide by zero with integers, your program will crash. 

If you divide by zero with floats, your program will take the limit and return +-Infinity or NaN. 

# Remainder Operator (%)
int result = 5 % 2; //result: 1

*/

// Challenge: The Four Sisters and the Duckbear (100 XP)

Console.WriteLine("How many eggs are there?");
int eggCount = Console.ReadLine();

int bearEggs = eggCount % 4;
int sisterEggs = eggCount / 4;

Console.WriteLine($"Each sister gets {sisterEggs} and the Duckbear gets {bearEggs}.");

// Ans: 3, 11, and 15 the bear will get more eggs then the sisters. 
