using System;

namespace ShapesLib
{
    public class Shape
    {
        public virtual int Area()
        {
            throw new NotImplementedException("Area() is not implemented");
        }
        
        /// <summary>
        /// Main method - entry point for the application.
        /// </summary>
        /// <param name="args">Command line arguments</param>
        static void Main(string[] args)
        {
            // Create a Rectangle instance
            Rectangle rect = new Rectangle();
            rect.Width = 3;
            rect.Height = 8;
            
            Console.WriteLine("Rectangle is a subclass of Shape");
            Console.WriteLine($"Width: {rect.Width}");
            Console.WriteLine($"Height: {rect.Height}");
            
            // Call Area method which should throw NotImplementedException
            try
            {
                int area = rect.Area();
                Console.WriteLine($"Area: {area}");
            }
            catch (NotImplementedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}