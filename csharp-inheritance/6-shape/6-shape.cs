using System;
using ShapesLib;

/// <summary>
/// Represents a rectangle, inheriting from Shape.
/// </summary>
public class Rectangle : Shape
{
    private int width;
    private int height;
    
    /// <summary>
    /// Gets or sets the width of the rectangle.
    /// </summary>
    public int Width
    {
        get { return width; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Width must be greater than or equal to 0");
            width = value;
        }
    }
    
    /// <summary>
    /// Gets or sets the height of the rectangle.
    /// </summary>
    public int Height
    {
        get { return height; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Height must be greater than or equal to 0");
            height = value;
        }
    }
    
    /// <summary>
    /// Main method - entry point for the application.
    /// </summary>
    /// <param name="args">Command line arguments</param>
    static void Main(string[] args)
    {
        // Test 1: Rectangle with width 3, height 8
        Rectangle rect1 = new Rectangle();
        rect1.Width = 3;
        rect1.Height = 8;
        
        Console.WriteLine("Rectangle is a subclass of Shape");
        Console.WriteLine($"Width: {rect1.Width}");
        Console.WriteLine($"Height: {rect1.Height}");
        
        // Call the base class Area method through the instance
        try
        {
            int area = rect1.Area();
            Console.WriteLine($"Area: {area}");
        }
        catch (NotImplementedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}