using System;

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Please enter your name: ");
        string name = "";
        try
        {
            name = Console.ReadLine();

            while (name == null || name.Length == 0)
            {
                Console.WriteLine("Name cannot be empty. Please try again.");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"Goodbye {name}.");
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }
}