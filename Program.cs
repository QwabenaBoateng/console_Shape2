using System;

class Program
{
    public static void Main(String[] args)
    {
        // Variable to store user's choice to continue or not
        int choice = 'y';
        
        // Loop to continue calculating area until the user decides to stop
        while (choice == 'y')
        { 
            // Prompt user to enter the type of shape
            Console.WriteLine("Enter the type of shape(circle, rectangle, triangle)");
            string shapeType = Console.ReadLine();
            double area = 0;

            // Calculate the area based on the type of shape entered
            if (shapeType == "circle")
            {
                // Prompt user to enter the radius of the circle
                Console.WriteLine("Enter the radius:");
                double radius = double.Parse(Console.ReadLine());
                // Calculate the area of the circle
                area = Math.PI * radius * radius;
            }
            else if (shapeType == "rectangle")
            {
                // Prompt user to enter the length of the rectangle
                Console.WriteLine("Enter the length:");
                double length = double.Parse(Console.ReadLine());
                // Prompt user to enter the width of the rectangle
                Console.WriteLine("Enter the width:");
                double width = double.Parse(Console.ReadLine());
                // Calculate the area of the rectangle
                area = length * width;
            }
            else if (shapeType == "triangle")
            {
                // Prompt user to enter the base length of the triangle
                Console.WriteLine("Enter the base length:");
                double baseLength = double.Parse(Console.ReadLine());
                // Prompt user to enter the height of the triangle
                Console.WriteLine("Enter the height:");
                double height = double.Parse(Console.ReadLine());
                // Calculate the area of the triangle
                area = 0.5 * baseLength * height;
            }
            else
            {
                // If an invalid shape type is entered, display an error message and exit
                Console.WriteLine("Invalid shape type entered.");
                return;
            }

            // Display the calculated area of the shape
            Console.WriteLine($"The area of the {shapeType} is {area}");
            
            // Ask the user if they want to continue
            Console.WriteLine("Wish to continue, y/n");
            // Convert the user's input to lower case and store it in the choice variable
            choice = Convert.ToChar(Console.ReadLine().ToLower());
        }
    }
}
