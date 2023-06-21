using System;

class Program
{
    static void Main(string[] args)
    {
        string myname = "Denis";
        string message = "My name is " + myname;

        string capsMessage = message.ToUpper();

        Console.WriteLine("My name is " + myname);
        Console.WriteLine(message);
        Console.WriteLine(capsMessage);

        string lowerMessage = "ORIGINALLY FULL CAPS".ToLower();
        Console.WriteLine(lowerMessage);


        Console.Read();
    }
}