using System;

// Classes are reference types, structs are value types -> A struct has to have a value
// Structs are not supporting inheritance
// Passed by value
// Cannot have null reference

struct Game
{
    public string name;
    public string developer;
    public double rating;
    public string releaseDate;

    /*
    public Game()
    {
                            -> Can not contain default constructors, only defined constructors
    }
    */

    public Game(string name, string developer, double rating, string releaseDate)
    {
        this.name = name;
        this.developer = developer;
        this.rating = rating;
        this.releaseDate = releaseDate;
    }

    public void Display()
    {
        Console.WriteLine("Game 1's name is : {0}", game1.name);
        Console.WriteLine("Game 1's developer is : {0}", game1.developer);
        Console.WriteLine("Game 1's rating is : {0}", game1.rating);
        Console.WriteLine("Game 1's was released in : {0}", game1.releaseDate);
    }
}

class Structs 
{
    static void Main(string[] args)
    {
        Game game1 = new Game("Pokemon GO", "Niantic", 3.50, "01.07.2016");
        game1.Display();
        
        
        Console.ReadKey();
    }
}