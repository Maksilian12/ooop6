using System;
using System.Collections.Generic;

// Абстрактний клас GraphicPrimitive
public abstract class GraphicPrimitive
{
    public int X { get; set; }
    public int Y { get; set; }

    public abstract void Draw();
    public abstract void Move(int x, int y);
}

// Клас Circle як спадкоємець GraphicPrimitive
public class Circle : GraphicPrimitive
{
    public int Radius { get; set; }

    public Circle(int x, int y, int radius)
    {
        X = x;
        Y = y;
        Radius = radius;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Circle at ({X}, {Y}) with Radius {Radius}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
    }
}

// Клас Rectangle як спадкоємець GraphicPrimitive
public class Rectangle : GraphicPrimitive
{
    public int Width { get; set; }
    public int Height { get; set; }

    public Rectangle(int x, int y, int width, int height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Rectangle at ({X}, {Y}) with Width {Width} and Height {Height}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
    }
}

// Клас Triangle як спадкоємець GraphicPrimitive
public class Triangle : GraphicPrimitive
{
    public int SideLength { get; set; }

    public Triangle(int x, int y, int sideLength)
    {
        X = x;
        Y = y;
        SideLength = sideLength;
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a Triangle at ({X}, {Y}) with Side Length {SideLength}");
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
    }
}

// Клас Group як спадкоємець GraphicPrimitive
public class Group : GraphicPrimitive
{
    private List<GraphicPrimitive> children = new List<GraphicPrimitive>();

    public void AddChild(GraphicPrimitive child)
    {
        children.Add(child);
    }

    public void RemoveChild(GraphicPrimitive child)
    {
        children.Remove(child);
    }

    public override void Draw()
    {
        Console.WriteLine("Drawing a Group:");
        foreach (var child in children)
        {
            child.Draw();
        }
    }

    public override void Move(int x, int y)
    {
        X += x;
        Y += y;
        foreach (var child in children)
        {
            child.Move(x, y);
        }
    }
}

// Клас GraphicsEditor
public class GraphicsEditor
{
    private List<GraphicPrimitive> primitives = new List<GraphicPrimitive>();

    public void AddPrimitive(GraphicPrimitive primitive)
    {
        primitives.Add(primitive);
    }

    public void RemovePrimitive(GraphicPrimitive primitive)
    {
        primitives.Remove(primitive);
    }

    public void DrawAll()
    {
        foreach (var primitive in primitives)
        {
            primitive.Draw();
        }
    }

    public void MoveAll(int x, int y)
    {
        foreach (var primitive in primitives)
        {
            primitive.Move(x, y);
        }
    }
}

class Program
{
    static void Main()
    {
        GraphicsEditor editor = new GraphicsEditor();

        Circle circle = new Circle(10, 10, 5);
        Rectangle rectangle = new Rectangle(20, 20, 8, 6);
        Triangle triangle = new Triangle(30, 30, 7);

        Group group = new Group();
        group.AddChild(circle);
        group.AddChild(rectangle);

        editor.AddPrimitive(group);
        editor.AddPrimitive(triangle);

        editor.DrawAll();
        editor.MoveAll(5, 5);
        editor.DrawAll();
    }
}
