# Level 19: Infomation Hiding

Object-Oriented Principle #2: Information Hiding - Only the object itself should directly access its data.

`public` - allows the field member to be access from anywhere.

`private` - allows only the object to access the data. 

To get around the problem of needing to change or access object data you can use Getters and Setters. 
```cs
private float _width;
private float _height;
private float _area;

public Rectangle(float width, float height)
{
  _width = width;
  _height = height;
  _area = width * height;
}

public void SetWidth(float value)
{
  _width = value;
  _area = _width * _height;
}

public void SetHeight(float value)
{
  _height = value;
  _area = _width * _heigth;
}
```

Simple getters and setters, that don't have anything extra needed, can be declared like this:
```cs
public float GetWidth() => _width;
public float GetHeigth() => _height;
public float GetArea() => _area;
```

The default accessability level is `private`. Fields should almost always be private. Programs should also follow a principle of least privilage needed.
Sometimes you will get privilage wrong, but it is always easier to make a private field public, then a public field private. 

Using Encapsulation and information hiding correctly leads to Abstraction. 

**Abstractions** - When the outside world doesn't know what is happening inside a price of code. Think inputs and outputs. As long at the correct outputs are received there is no need to know how it works.
This is Abstraction. 

There is a third access modifier: `internal` - This allows a class to be only accessable within its own project. `public` can be used anywhere, accross any project. Think `Console` or `Convert`, 
but internal classes can only be used by thier containing project. While we are building self contained projects `internal` and `public` are essentially the same.

`internal` is the default access level for a class who's access level isn't explicitly defined. 
