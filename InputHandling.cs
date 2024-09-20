// For handling input and user control logic 
using System;
using static UserInterface;

public static class InputHandling
{
    public static void ProcessInput(string input)
    {
        switch (input)
        {
            case "h":
            case "help":
                PrintHelp();
                break;
            default:
                PrintInvalidInputMessage(input);
                break;
        }
    }
}
