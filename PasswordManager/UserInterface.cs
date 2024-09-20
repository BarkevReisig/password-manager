// Text outputs, instructions, and menus
using System;

public static class UserInterface
{
    public static void PrintWelcome()
    {
        Console.WriteLine("WelcomeMessage");
    }

    public static void PrintMenu()
    {
        Console.WriteLine("Menu");
    }

    public static void PrintHelp()
    {
        Console.WriteLine("Help");
    }

    public static void PrintInvalidInputMessage(string input)
    {
        Console.WriteLine($"{input} is not a valid command");
    }
}

