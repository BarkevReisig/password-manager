using System;
using static UserInterface;

// For handling input and user control logic.
// ProcessInput() is the entry method which will call the
// relevant methods for the supplied user input.
//
// Terminology:
// entry - A row of data containing a service, username, and password.
// service - The website, app, etc. that the entry is for. Acts as the id so no duplicates.
// username - The email or other identifier used for the service.
// password - The password.
public static class InputHandling
{
    // Parses input to call the method that matches the command
    // specified within input. Parameter input must have format:
    // "command arg1 arg2 ..." in order to be parsed correctly.
    // Unkown commands simply print an error message.
    public static void ProcessInput(string input)
    {
        string[] parsedInput = input.Split(" ");
        
        switch (parsedInput[0])
        {
            case "h":
            case "help":
                PrintHelp();
                break;
            case "ce":
            case "create":
                CreateEntry(parsedInput);
                break;
            case "de":
            case "delete":
                break;
            case "gd":
            case "get":
                break;
            default:
                PrintInvalidInput(parsedInput[0]);
                break;
        }
    }

    // Changes the username linked to the specified service.
    private static void ChangeUsername(string[] parsedInput)
    {
    }

    // If parsedInput does not have length 3, prints a warning and returns.
    // If parsedInput[1] is an already existing service, prints a warning and returns.
    // Othewise, creates a new entry with service = parsedInput[1] and username = parsedInput[2]
    // and password = a randomly generated sequence of symbols.
    private static void CreateEntry(string[] parsedInput)
    {
    }
    
    // Deletes the entry specified entry.
    private static void DeleteEntry(string service)
    {
    }

    // Generates a new password to replace the password paired with the specified service.
    private static void GenerateNewPassword(string service)
    {
    }

    // Retrieves the login data for the specified service.
    private static void GetLoginData(string service)
    {
    }
    
    // Undos the last data-changing action taken.
    private static void Undo()
    {
    }
}
