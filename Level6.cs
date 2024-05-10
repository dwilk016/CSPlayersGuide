// Level 6: The C# Type System

/*
Notes:

bit - a single 1 or 0
byte - 8 bits

Binary -- Decimal 
0000 -- 0
0001 -- 1
0010 -- 2
0011 -- 3
0100 -- 4
1000 -- 8

Binary -- Letters
0100 0001 -- A
0100 0010 -- B

Integer Types:
byte - 1 - no - 0 - 255
short - 2 - yes - -32,768 - 32,767
int - 4 - yes - -2,147,483,648 - 2,147,483,647
long - 8 - yes - -9,233,372,036,854,775,808 - 9,233,372,036,854,775,807
sbyte - 1 - yes - -128 - 127
ushort - 2 no - 0 - 65,535
uint - 4 - no - 0 - 4,294,967,295
ulong - 8 - no - 0 - 18,446,744,073,709,551,615

numbers literals are declared as ints unless otherwise told. 
  35 - is declared as an int
  35L - is declared as a long
  35U - is declared as the smallest unsigned type (either uint or ulong)
  35UL - is declared as a unsigned long

You cannot declare short or byte literals, but note that computers will upgrade short and byte types to ints
to do math on them anyway. You should only use byte or short when there is clear benefit. 

Digit Seperator: normally we will write 1,000,000 to help read the number, but in code we can't do this.
So we use underscores instead.
  int x = 5000;
  int x = 5_000; // same
  
Binary or Hex
You can declare binary or hex literals with a 0b or 0x prefix.
  int 0b1010; // 10 in binary
  int 0xB; // 10 in hex

Character and String Types:
char holds a single character. 

char letter = 'a'; // uses single quotes
char letter = '\u0061'; // unicode can be used with the \u prefix. 

string text = "Hello, World"; // uses double quotes

Floating Point Types:
Floating point types are used to represent fractional values (real numbers) to varying degrees of accuracy. 

float - 4 - +-1.0x10^-45 - +-3.4x10^38 - 7
double - 8 - +-5x10^-324 - +-1.7x10^308 - 15 or 16
decimal - 16 - +-1x10^-28 - +-7.9x10^28 - 28 or 29 

float and double are hardware supported and very fast. deciaml is not, therfore slower, but is more accurate.
decimal is primarily used where accuracy is paramount like finance.

fractions will be declared as doubles unless otherwise told
  double PI = 3.14159
  float PI = 3.14159f // f for float
  decimal PI = 3.14159m // m for money. 

You can also use exponential notation to declare a double. 
  double avogadrosNuber = 6.022e23

Bool Type:
Boolean Logic type is TRUE (1) or FALSE (0)

bool isNull = FALSE;
bool isToday = 1;
*/

// Challenge: The Variable Shop (100 XP)
byte smallest = 1;
sbyte verySmall = -5;
short small = 35;
ushort sortOfSmall = 43;
int medium = 324;
uint kindaBig = 435;
long big = 54_783L;
ulong biggest = 5_456_434UL;

float PI = 3.14159f;
double number = 6.19343;
decimal money = 5.345e34m;

char letter = 'a';
string text = "Hello, World!";

bool logic = true; // must be lowercase

Console.WriteLine("byte: " + smallest);
Console.WriteLine("sbyte: " + verySmall);
Console.WriteLine("short: " + small);
Console.WriteLine("ushort: " + sortOfSmall);
Console.WriteLine("int: " + medium);
Console.WriteLine("uint: " + kindaBig);
Console.WriteLine("long: " + big);
Console.WriteLine("ulong: " + biggest);
Console.WriteLine("char: " + letter);
Console.WriteLine("string: " + text);
Console.WriteLine("float: " + PI);
Console.WriteLine("double: " + number);
Console.WriteLine("decimal: " + money);
Console.WriteLine("bool: " + logic);

// Challenge: The Variable Shop Returns (50 XP)

smallest = 5;
verySmall = 6;
small = 46;
sortOfSmall = 18;
medium = 1_435;
kindaBig = 45_435;
big = 544_783L;
biggest = 51_456_434UL;

PI = 64.3543f;
number = 4.343;
money = 9.999e-10m;

letter = 'z';
text = "Goodbye, World!";

logic = false;

Console.WriteLine("byte: " + smallest);
Console.WriteLine("sbyte: " + verySmall);
Console.WriteLine("short: " + small);
Console.WriteLine("ushort: " + sortOfSmall);
Console.WriteLine("int: " + medium);
Console.WriteLine("uint: " + kindaBig);
Console.WriteLine("long: " + big);
Console.WriteLine("ulong: " + biggest);
Console.WriteLine("char: " + letter);
Console.WriteLine("string: " + text);
Console.WriteLine("float: " + PI);
Console.WriteLine("double: " + number);
Console.WriteLine("decimal: " + money);
Console.WriteLine("bool: " + logic);

/*
Notes:
Type Inference:
var can be used to infer a type, but the values must be initalized when it is declared. 
  var number = 5; // int
  var text = "Hello"; // string
  var character = 'g'; // char
  var isTrue; // invalid

Use Case:
var input = Console.ReadLine(); // can take strings, char, int, or long. 

Once it is initalized you cannot change the type. 

The Convert and Parse Class:
You can use the convert class to convert between types. 

Convert.ToWhatever();

.ToByte()
.ToInt16()
.ToInt32()
.ToInt64()
.ToSByte()
.ToUInt16()
.ToUInt32()
.ToUInt64()
.ToChar()
.ToString()
.ToSingle()
.ToDouble()
.ToDecimal()
.ToBool()

Most Types have a .Parse() Method as well
int.Parse("42069"); // converts a string to an int
*/

/*
Knowledge Check: Type System (25 XP)
1. False
2. byte, short, int, long
3. false
4. uint
5. float, double, decimal
6. double
7. decimal
8. string
9. bool
