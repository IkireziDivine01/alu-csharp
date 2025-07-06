using System;

/// <summary>
/// Represents a square, which is a type of rectangle with equal width and height.
/// </summary>
public class Square : Rectangle
{
    private int size;

    /// <summary>
    /// Gets or sets the size of the square.
    /// </summary>
    public int Size
    {
        get { return size; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Size must be greater than or equal to 0");

            size = value;
            Width = value;
            Height = value;
        }
    }

    /// <summary>
    /// Returns a string representation of the square.
    /// </summary>
    public override string ToString()
    {
        return $"[Square] {size} / {size}";
    }
}
