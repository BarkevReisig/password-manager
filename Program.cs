using System;
using static InputHandling;
using static UserInterface;

// On program start...
PrintWelcome();
// ...

// Main loop...
while (true)
{
    string input = Console.ReadLine() ?? throw new NullReferenceException();
    input = input.ToLower();
    if (input is "q" or "quit")
    {
        return;
    }
    ProcessInput(input);
}
