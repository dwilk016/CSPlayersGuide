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
