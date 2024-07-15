using System;
public class Octopus
{
    // Fields
    public string Name;
    public string Color;
    public int Tentacles;

    // Constructor to initialize fields
    public Octopus(string name, string color, int tentacles)
    {
        Name = name;
        Color = color;
        Tentacles = tentacles;
    }

    // Method to display octopus details
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Color: {Color}");
        Console.WriteLine($"Number of tentacles: {Tentacles}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Octopus
        Octopus octo = new Octopus("Ollie", "Purple", 8);

        // Display octopus details
        octo.DisplayInfo();
    }
}