using System;
using System.Reflection;

/// <summary>
/// Provides utility methods for inspecting objects using reflection.
/// </summary>
public class Obj
{
    /// <summary>
    /// Prints the names of the public properties and methods of the specified object.
    /// </summary>
    /// <param name="myObj">The object to inspect.</param>
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();

        Console.WriteLine($"{type.Name} Properties:");
        foreach (PropertyInfo prop in type.GetProperties())
        {
            Console.WriteLine(prop.Name);
        }

        Console.WriteLine($"{type.Name} Methods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}

/// <summary>
/// Represents a dog with basic properties and behaviors.
/// </summary>
public class Dog
{
    // Initialize the field with a default value to avoid nullable warning
    private string name = "";
    private int age;
    private int happiness;

    /// <summary>
    /// Gets or sets the name of the dog.
    /// </summary>
    public string Name 
    { 
        get { return name; } 
        set { name = value; } 
    }

    /// <summary>
    /// Gets or sets the age of the dog.
    /// </summary>
    public int Age 
    { 
        get { return age; } 
        set { age = value; } 
    }

    /// <summary>
    /// Gets or sets the happiness level of the dog.
    /// </summary>
    public int Happiness 
    { 
        get { return happiness; } 
        set { happiness = value; } 
    }

    /// <summary>
    /// Makes the dog bark.
    /// </summary>
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var a = new Dog();
        Obj.Print(a);
    }
}