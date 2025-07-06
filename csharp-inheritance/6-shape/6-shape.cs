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
    /// Calculates and returns the area of the rectangle.
    /// </summary>
    /// <returns>The area of the rectangle (width * height).</returns>
    public override int Area()
    {
        return width * height;
    }
    
    /// <summary>
    /// Main method - entry point for the application.
    /// </summary>
    /// <param name="args">Command line arguments</param>
    static void Main(string[] args)
    {
        // Create a rectangle instance
        Rectangle rect = new Rectangle();
        rect.Width = 5;
        rect.Height = 3;
        
        Console.WriteLine($"Rectangle Width: {rect.Width}");
        Console.WriteLine($"Rectangle Height: {rect.Height}");
        Console.WriteLine($"Rectangle Area: {rect.Area()}");
        
        // Test validation
        try
        {
            rect.Width = -1; // This should throw an exception
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}