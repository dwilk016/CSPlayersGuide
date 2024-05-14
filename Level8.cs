// Level 8: Console 2.0

/*
# The Console Class

Console.Write() -- similar to WriteLine(), without the new line

Console.ReadKey() -- reads a single key
Console.ReadKey(true) -- will not display the pressed key

Console.BackgroundColor -- sets the background color
Console.ForegroundColor -- sets the foreground color

Console.Clear() -- Clears terminal

Console.Title = "Hello, World!"; -- changes the title bar of the terminal

Console.Beep(); -- beeps
Console.Beep(freq, duration); // 1000 = 1 sec

'\' is called the escape character. 
  \" - quotes in strings
  \n - new line
  \r - return to start of line
  \t - tab
  \\ - allows a backslash in strings

"C:\\user\\desktop\\file" - using escape characters
@"C:\user\desktop\file" - using verbatim character before quotes

int answer = 20;
$"The answer is {answer}." - using string interpolation

$"#1:{answer, 20}" will right align at 20 characters. // #1:                  20 
$"{answer, -20} - 2" will add 20 characters of whitespace. // 20                   - 2

// # doesn't display non-significant 0s
$"{42:#.##}" - result: 42
$"{3.14159:#.##}" - result: 3.14

// 0 does display significant 0s
$"{42:000.000} - result: 042.000

// % displays percentage
$"{0.55:0.00%}" - result: 55.00%

P - 0.00%
P1 - 0.0%
F - 0.00
F5 - 0.00000

*/

//Challenge: The Defense of Consolas

Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());
        
Console.Write("Target Column? ");
int column = Convert.ToInt32(Console.ReadLine());
        
Console.WriteLine("Deploy to: ");
Console.WriteLine($"({column + 1}, {row})");
Console.WriteLine($"({column - 1}, {row})");
Console.WriteLine($"({column}, {row + 1})");
Console.WriteLine($"({column}, {row - 1})");

