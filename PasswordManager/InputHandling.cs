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
    // Correct commands that expect different arguments than given
    // will call the relevant methods but any error handling will
    // take place there.
    public static void ProcessInput(string input)
    {
        string[] parsedInput = input.Split(" ");
        
        switch (parsedInput[0])
        {
            case "h":
            case "help":
                PrintHelp();
                break;
            default:
                PrintInvalidInput(input);
                break;
        }
    }

    // Changes the username linked to the specified service.
    private static void ChangeUsername(string service)
    {
    }

    // Creates a new entry for the specified service using the specified username.
    private static void CreateEntry(string service, string username)
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
    
    // Undos the last action taken.
    private static void Undo()
    {
    }
}
