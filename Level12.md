# Level 12: Arrays
An array is used to store a whole range of values in a single variable

## Creating an Array
```cs
int[] scores;
```
the `[ ]` indicate that this variable stores many values instead of just one and can only store values of a single type.

After you declare an array the next step is to construct a new array to hold our items. 
```cs
int [] scores = new int[10];
```

The `new` keyword creates new things in your program. This creates space to hold 10 int values. Note, that once an array
has been constructed it's size can no longer be changed. However you can create a new array to meet your needs. 
```cs
scores = new int[20];
```

### Getting and Setting values in Arrays
To assign a value to an array use the index operator.
```cs
scores[0] = 99;
```
This code assigns the value 99 to the 0th place. The index can be any int expression, not just litterals. 
```cs
scores[someSpot + 1]
```
This is just as valid. 

Note: Arrays in C# use 0-based indexing, which means the first location is the 0th index. 

### Default Values
When you initialize an Array it writes all the bits to 0. 
For int and floats this is the number 0. For bools it is false. For Char and String it is Null. 

### Crossing Array Bounds
Attempting to access values outside of the range of an array will result in an out-of-bounds error that will crash the program if not addressed. 
You can use the `.Length` property of an array to see how long it is. 
```cs
Console.WriteLine(scores.Length); //writes how long the array is.
```

For loops are very common ways to handle arrays
```cs
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];

for (int i = 0; i < array.Length; i++) {
  array[i] = 1;
}
```
The following code takes all the values of the array and sets them to 1.

### Indexing from the end
If you want to work from the end of an array you can use `^` to count from the end of an array.
```cs
int lastScore = scores[^1];
```
Note: When counting forward you start from 0, but going backwards you start from 1.
```cs
scores[0] == scores[^5];
scores[1] == scores[^4];
scores[2] == scores[^3];
scores[3] == scores[^2];
scores[4] == scores[^1];
```

### Ranges
you can also grab a copy of a range of values using the `( .. )` or range operator.
```cs
int[] firstThreeScores = scores[0 .. 3];
```
The first number is the index to start at, the second it the number to end at, but not include. ie [a .. b).

You can also use `^` in range operators
```cs
int theMiddle[] = scores[1 .. ^1];
```

If you leave one of the values out it will just start/end at the beggining. 
```cs
int firstTwo = scores[ .. 3];
int lastTwo = scores[^2 .. ];
```

## Other ways to create arrays
You can use collection initializer syntax to initialize arrays
```cs
int[] scores = new int[10] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int[] scores = new int[] {1, 2, 3, 4, 5};
int[] scores = new [] {1, 2, 3, 4, 5, 6, 7, 8};
```
All three syntaxes are valid.

## Examples
Find the minimum value
```cs
int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

int currentSmallest = int.MaxValue;
for (int index = 0; index < array.Length; index++) {
  if (array[index] < currentSmallest) {
    currentSmallest = array[index];
  }
}

Console.WriteLine(currentSmallest);
```

Find the average value
```cs
int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

int total = 0;
for (int index = 0; index < array.Length; index++) {
  total += array[index];
}

double average = (double)total/array.Length;
Console.WriteLine(average);
```

## Challenge: The Replicator of D'To
```cs
int[] originalArray = new int[5];

for (int index = 0; index < originalArray.Length; index++) {
  Console.Write($"Enter a value for index {index}: ");
  originalArray[index] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Duplicating...");
int[] duplicateArray = new int[5];
for (int index = 0; index < duplicateArray.Length; index++) {
  duplicateArray[index] = originalArray[index];
}

for (int index = 0; index < originalArray.Length; index++) {
  Console.WriteLine($"originalArray[{index}]: {originalArray[index]}");
}

Console.WriteLine();
for (int index = 0; index < duplicateArray.Length; index++) {
  Console.WriteLine($"duplicateArray[{index}]: {duplicateArray[index]}");
}
```
## The `Foreach` loop
The foreach loop is specially designed for arrays. 
```cs
int[] scores = new int[10];

for (int index = 0; index < scores.Length; index++) {
  int score = scores[index];
  Console.WriteLine(scores);
}
```
This is simplified with a foreach loop
```cs
int[] scores = new int[10];

foreach (int score in scores) {
  Console.WriteLine(scores)
}
```
The one downside of a foreach loop is that you lose knowledge of what index you are at. If you need to know the position you are better off with a for loop. Foreach loops also run
slightly slower then for loops, so if preformance becomes an issue then rewrite foreach as for loops.

## Challenge: The Laws of Freach
```cs
int[] array = new int[] {4, 51, -7, 13, -99, 15, -8, 45, 90};

int currentSmallest = int.MaxValue;
foreach (int element in array)
  if (currentSmallest > element)
    currentSmallest = element;
Console.WriteLine(currentSmallest);

int total = 0;
foreach (int element in array) 
  total += element;
double average = (double)total/array.Length;
Console.WriteLine(average);
```

## Multi-Dimensional Arrays
There is no limit to what you can make an array out of. You can have an array of arrays!
```cs
int[][] matrix = int[3][];
matrix[0] = new int[] {1, 2};
matrix[1] = new int[] {3, 4};
matrix[2] = new int[] {5, 6};

Console.WriteLine(matrix[0][1]) // Result: 2
```
When each of the inner arrays needs to be different size, that is known as a jagged array. 

Multidimensional arrays are created as follows:
```cs
int[,] matrix = new int[3, 2] { {1, 2}, {3, 4}, {5, 6} };

Console.WriteLine(matrix[0, 1]); // Result: 2
```

You can have many dimensional multi-dimensional arrays or arrays
```cs
int [][,] matrix = new int[3][,]; // an array of multi-dimensional arrays
matrix[0] = new int[3,3];
matrix[1] = new int[3,3];
matrix[2] = new int[3,3];

int matrix[,,][] = new int[3,3,3][]; // a multi-dimensional array where each element is an array.
matrix[0,0,0] = new int[3]; matrix[0,1,0] = new int[3]; matrix[0,2,0] = new int[3];
matrix[0,0,1] = new int[3]; matrix[0,1,1] = new int[3]; matrix[0,2,1] = new int[3];
matrix[0,0,2] = new int[3]; matrix[0,1,2] = new int[3]; matrix[0,2,2] = new int[3];

matrix[1,0,0] = new int[3]; matrix[1,1,0] = new int[3]; matrix[1,2,0] = new int[3];
matrix[1,0,1] = new int[3]; matrix[1,1,1] = new int[3]; matrix[1,2,1] = new int[3];
matrix[1,0,2] = new int[3]; matrix[1,1,2] = new int[3]; matrix[1,2,2] = new int[3];

matrix[2,0,0] = new int[3]; matrix[2,1,0] = new int[3]; matrix[2,2,0] = new int[3];
matrix[2,0,1] = new int[3]; matrix[2,1,1] = new int[3]; matrix[2,2,1] = new int[3];
matrix[2,0,2] = new int[3]; matrix[2,1,2] = new int[3]; matrix[2,2,2] = new int[3];
```
This gets complicated fast so proceed with caution.

When looping through multi-dimensional arrays you are going to want to use the .GetLength() Method, handing it the dimension you are interested in.
```cs
int[,] matrix = new int[4,4];

for (int row = 0; row < matrix.GetLength(0); row++)
{
  for (int column = 0; column < matrix.GetLength(1); column++)
  {
    Console.Write(matrix[row, column] + " ");
  }
  Console.WriteLine();
}
```
