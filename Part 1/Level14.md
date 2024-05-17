# Level 14: Memory Management
## Memory and Memory Management
Memory is a limited resource and must be managed carefully. Using memory is fine, but you must clean up after yourself when you finish using it. 
There are two models for handeling memory, The Stack and The Heap.

## The Stack
The stack is like a stack of boxes, each box contains the local variables and parameters for a method. 
Consider:
```cs
int x = 3;
double y = 6.022;
Method1();

void Method1()
{
    int a = 3;
    int b = 6;
}
```
As Main starts we reserve 4 bytes for x and 8 bytes for y, so 12 bytes total are set aside for Main. This collection of data for a single method is known as a frame. 

The first two lines declare and initialize x and y into memory. 

Next we invoke `Method1()`.

When `Method1()` is invoked we resever space for a and b, but also note where we are at so we can return to that location. All of this is added to a new frame. 

The Main frame is now burried beneath the Method1() frame and is generally inaccessable. 

Once Method1() is done. We return to line three and the memory from its frame is released. The Main method is now on top of the stack and can bu used.  

Parameters for a method are initialized, after the frame is reserved, but before the local variables are initalized. This allows the method to copy the variable information into the frame. Returns, likewise are also reserved a place in the frame and allow the information to be coppied back before a frame is deallocated. 

Arrays and Strings, as well as other types, are unpredictable in size and do not work well with a stack. For that we have another memory management method: The Heap!

## The Heap
The heap is an arbitrary size that is less organized then the stack. When a string is allocated, it looks for the first avalible place where it will fit on the heap. This means that it is neither predictable or computable for size and location. This location on the heap is recorded with a reference, and it is this reference that is stored by the variable on the stack.

### Value types and reference types
This should make clear that there are two very different categories of types. Value Types (int, double, char) which are fixed in size and reference type (string, int[], double[,]) which are variable in size. 

The fact that reference types only store a "reference" in the variable is important. 
```cs
int a1, a2; // declares 2 of everything
string s1, s2;

a1 = 2; // initializes values into the first
s1 = "Hello";

a2 = a1; // copies the first to the second
s2 = s1;

a1 = 4; // changes the first
s1 = "goodbye";

Console.WriteLine(a2); //Result: 2
Console.WriteLine(s2); //Result: Goodbye
```

Even though we only made a change to s1, s2 says goodbye! this is because s1 and s2 hold the same REFERENCE to a location on the heap. If you change the value in the heap, they will still both point to that location!

### Value symantics and Reference Symantics
This has a huge ramifications for how we handle reference types and value types. for example:
```cs
int a = 88;
int b = 88;

bool areEqual = (a == b); // will be true

int[] arrayA = new int[] {1, 2, 3};
int[] arrayB = new int[] {1, 2, 3};

bool areArraysEqual = (arrayA == arrayB); // will be false since the references are different!
```

With value types you can compare the data directly. With reference types you are comparing weather the references are the same, not the data contained by those references. 

Note: that some reference types redefine the equailty to make it more like a value type, like strings. 
```cs
string a = "hello"; 
string b = "hello"; // these are two different references with the same values

bool areEqual = (a == b); // is true because the string has redefined the == to be more inline with value types. 
```

## Cleaning up Heap Memory
Heap Memory is a little more tricky to clean up. mismanaging this can lead to memory leaks where the memory is never released and cant be reused. Or dangling pointers where the memory is release too early and part of the program still needed it. This can be a problem because if another part of the program overwrites that data, your dangling pointer now has access to memory that wasn't ment for it. 

### Automatic Memory Management
The long and short of it is that C# handles memory management for you automatically with a garbage collector. This is a program that is highly optomized to run serveral times a second to make sure if anything on the heaps isn't being used that it is returned to memory. It is very complex and in some cases can slow down a program, but for the most part it takes the burden of memory management off the programmer. 

## Knowledge Check: Memory
1. False
2. True
3. True
4. False
5. True
6. False
7. True
8. False
