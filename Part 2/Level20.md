# Level 20: Properties

Information hiding is important, but it adds significant complexity to our code. For example three field and a constructor becomes:
```cs
public class Rectangle
{
    // MEMBER FIELDS
    private float _width;
    private float _height; 

    // CONSTRUCTOR
    public Rectangle(float width, float height) 
    {
        _width = width;
        _height = height;
    }

    // GETTERS
    public float GetWidth() => _width; 
    public float GetHeight() => _height;
    public float GetArea() => _width * _height;

    // SETTERS
    public void SetWidth(float value) => _width = value;
    public void SetHeight(float value) => _height = value;
}
```
and instead of `rectangle._width = 3` we get `rectangle.SetWidth(3)`. This is a lot of complexity for what started as three fields and a constructor. 

Using a **PROPERTY** we can simplify this code. A property pairs a getter and setter under a shared name with field-like access. 

A property is a type of member that can be placed in a class. Every property comes with a type (int, float, char, bool, etc.) and an modifiers like access level (public, private, internal) and others.
Properties are uses UpperCamelCase. Every property defines a pair of getters (get) and setters (set). Properties are used with a *backing field* of the same name (ie _width and Width). Properties do
not require both getters and setters, you can have only one. So our Property-based Rectangle becomes:
```cs
public class Rectangle
{
    // MEMBER FIELDS (BACKING FIELDS)
    private float _width;
    private float _height; 

    // CONSTRUCTOR
    public Rectangle(float width, float height) 
    {
        _width = width;
        _height = height;
    }

    // PROPERTIES
    public float Width
    {
        get => _width;
        set => _width = value;
    }

    public float Height
    {
        get => _height;
        set => _height = value;
    }

    public float Area => _width * _height;
}
```
This allows us to write more readable code in Main. `rectangle.Width = 3` is vaild!

You can also adjust getter and setter access level independently of the Property
```cs
public float Width
{
    get => _width;
    private set => _width = value;
}
```

## Auto Implemented Properties
We can make the code ever simpler if the properties do not need any complex logic for the getters and setters. 
```cs
public float Width
    {
        get => _width;
        set => _width = value;
    }
```
Becomes
```cs
public float Width { get; set; }
```
This greatly simplifies things! Now out code becomes:
```cs
public class Rectangle
{
    // PROPERTIES
    public float Width { get; set; }
    public float Height { get; set; }
    public float Area => Width * Height;

    // CONSTRUCTOR
    public Rectangle(float width, float height) 
    {
        _width = width;
        _height = height;
    }
}
```

This implimentation does away with the backing fields, so if you need to initialize a field you can do it like this:
```cs
public float Width { get; set; } = 45f;
```

## Immutable Fields and Properties
Properties and Fields can be Get-Only. This makes it so that after they are initilized that cannot be changed. There is no Get-Only as this is not useful and is essentially a black hole for data. 
These are also refered to as Read-Only Properties.

The same can be done with a field with the `readonly` modifier. Here is an example of both:
```cs
public class Player
{
    // PROPERTY
    public string Name { get; } = "Player 1";

    // CONSTRUCTOR
    public Player(string name)
    {
        Name = name;
    }
}
```

OR
```cs
public class Player
{
    // FIELD
    private readonly string _name; 

    // CONSTRUCTOR
    public Player(string name)
    {
        _name = name;
    }
}
```

When every Property and Field is immutable the entire object is said to be immutable. 

## Object Initializer Syntax and `INIT` Properties
We can initialize a property right after construction with Object Initializer Syntax
```cs
public class Circle
{
    public float X { get; set; } = 0;
    public float Y { get; set; } = 0;
    public float Radius { get; set; } = 0;
}
```

Normally we would initialize properties like this
```cs
Circle circle = new Circle();
circle.Radius = 3;
circle.X = -4;
```

With Object Initializer Syntax this becomes
```cs
Circle circle = new circle() { Radius = 3, X = -4 };
```
You cannot use Object Initializer Syntax with getonly properties. 

This `init` accessor makes it so that you can only set a property at initialization:
```cs
public class Circle
{
    public float X { get; init; } = 0;
    public float Y { get; init; } = 0;
    public float Radius { get; init; } = 0;
}

Circle circle = new Circle() { X = 1, Y = 2, Radius = 3 };

// cirlce.X = 2 // this will fail because you can only make a change during initialization.
```
