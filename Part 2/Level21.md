# Level 21: Static

## Static Members
The `static` modifier allows fields to be shared amoung instances of a class.
```cs
public class SomeClass
{
    private int _number; // this field is unique to each instance.
    private static int _age; // this field is shared amoung all instances. 
}
```

## Static Fields
Static fields are usefull for when a field affects every instance of a class. We also tend to use UpperCamelCase when creating static fields. 
```cs
public class Score
{
    private static readonly int PointThreshold = 1000;
    private static readonly int LevelThreshold = 4;
}
```

## Global State
> [!Caution]
> When you create a field that is static, public, and not readonly it is called a ***global state***. Global state is concidered dangerous because it can result in bugs that take a long time to
> track down. Therefore you are better off avoiding them.

## Static Properties
Properties can be made static. They can use static fields as their backing fields or you can use auto-properties. These can have the same global state issues as field so be careful.

An example that uses static properties is the Console Class. Console.Foreground, Console.Title are static properties. Note when someone changes the Foreground Color to Red everything is red until someone changes it back.

## Static Methods
Methods can also be static. A static method is not tied to any single instance so it cannot refer to any non-static fields, properties, or methods. 

A common use for static methods is to create a **Factory Method**. This creates a new instance for the outside world as an alternative to calling a constructor. For example:
```cs
public static Rectangle CreateSquare(float size) => new Rectangle(size, size)
```
This method is called like this:
```cs
Rectangle rectangle = Rectangle.CreateSquare(2);
```

This is how we have been calling things like Console.WriteLine() and Convert.Int32().

## Static Constructors
If a class has static fields or properties, you may need to run a static constructor to initialize them:
```cs
public class Score
{
    public static readonly int PointThreshold;
    public static readonly int LevelThreshold;

    static Score()
    {
        PointThreshold = 1000;
        LevelThreshold = 4;
    }
}
```
You cannot call this constructor directly, it instead runs when the class is first used. Becasue of this it cannot be use accessability modifiers like private or public.

## Static Classes
Static classes will prevent the creation of instances of that class. This allows the creation of related utility methods, fields, and properties. Console, Convert, and Math are examples of 
Static classes. 

## Challenge: Arrow Factory
