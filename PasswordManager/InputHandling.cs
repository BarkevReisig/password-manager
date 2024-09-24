// For handling input and user control logic 
using System;
using static UserInterface;

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

    // Retrieve password for a specified account (email, service pair)
    private static void GetPassword(string service, string email)
    {
    }
    
    // Generate password to link with a new specified account
    private static void GeneratePassword(string service, string email)
    {
    }
    
    // Generate new password to replace a password linked with an existing account
    private static void GenerateNewPassword(string service, string email)
    {
    }

    // Change the email linked to a specified service
    private static void ChangeEmail(string service)
    {
    }

    // Delete an entire account entry
    private static void DeleteAccount(string service, string email)
    {
    }

    // Undo the last action taken
    private static void Undo()
    {
    }
}
