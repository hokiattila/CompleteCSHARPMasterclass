using System;

class Program 
{
    static void Main(string[] args)
    {

        /**

        Console.Write("text here"); // keeps cursor in the same line

        Console.WriteLine("text here"); // puts the cursor in the next line (linebreak)
        
        Console.Read(); // takes a single input of string and returns the ASCII value
        
        Console.ReadLine(); // takes a string or integer input and returns it as the Output
        
        Console.ReadKey(); // takes a single character and return Key Info
        
        */

        Console.WriteLine("Hello Welcome");
        Console.Write("Hello");
        Console.Write("Welcome");

        Console.Write("\nEnter a string and press enter:");
        string readInput = Console.ReadLine();
        Console.WriteLine("You have entered {0}", readInput);

        Console.Write("Enter a char and press enter:");
        int asciiValue = Console.Read();
        Console.WriteLine("\nASCII value is {0}", asciiValue);
        Console.ReadKey();

        

        Console.Read();
    }
}