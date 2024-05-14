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

/*
Notes:
'=' is the assignment operator. 

'a += 5' is the same as a = a + 5
'a -= 5' is the same as a = a - 5
'a *= 5'
'a /= 5'
'a %= 5'

a++ is a = a + 1
a-- is a = a - 1

*/

//Challenge: The Dominion of Kings

Console.Write("Number of Estates: ");
string estateCount = Console.ReadLine();
Console.Write("Number of Duchy: ");
string duchyCount = Console.ReadLine();
Console.Write("Number of Province: ");
string provinceCount = Console.ReadLine();

int score = Convert.ToInt32(estateCount) + Convert.ToInt32(duchyCount) * 3 + Convert.ToInt32(provinceCount) * 6;

Console.WriteLine($"Your score is {score}.");


/*
Notes:
you can place the ++ or -- before or after the variable. 

++x will evaluate the increment, then assign it. 
x++ will assign the variable, then increment it.

int x = 5;
int y = x++; // result: y = 5

int x = 5;
int z = ++x; // result: z = 6

# Different Types and Casting
There are two types of conversion between types. Widening (no lose of information byte => int) and narrowing (lose of information, int => byte).
Widening is implicit, Narrowing is explicit. 

byte aByte = 3;
int anInt = aByte;

int anInt = 3;
byte aByte = (byte) anInt; //this is known as casting and is an explicit conversion.

consider: 
short a = 2;
short b = 3;
int c = a + b; // a and b are converted to ints automatically

short a = 2;
short b = 3;
short c = (short)(a + b); // since math is done in ints a + b returns an int and must be cast down. Casting also has a high order of precidence. 

# Math and MathF class
Math.Pow(x, y) -- x^y
Math.Sqrt(x) -- sqrt(x)
Math.Sin(x) -- sin(x) // x is in radians
Math.Cos(x) -- cos(x)
Math.Min(x, y) -- returns the smaller
Math.Max(x, y) -- returns the larger
Math.Clamp(x, 0, 100) -- returns only 0<x<100

MathF is the same, but with doubles. 
