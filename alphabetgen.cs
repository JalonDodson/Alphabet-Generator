using System;
using System.Linq;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        // userInput and alphabet variables to check if 
        string userInput;
        string[] alphabet = {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };
        List<string> alphabetList = new(alphabet);

        while (true)
        {
            Console.WriteLine("Input string (up to 256 characters): ");
            userInput = Console.ReadLine();
            if (userInput.Length > 256)
            {
                Console.WriteLine("Invalid string length (1-256 characters). ");
            }
            else
            {
                break;
            }
        }

        for (int i = 0; i < userInput.Length; i++)
        {
            if (alphabetList.Contains(userInput[i].ToString().ToLower()))
            {
                alphabetList.Remove(userInput[i].ToString().ToLower());
            }
        }

        Console.WriteLine("Characters not in user's input:");

        foreach (string character in alphabetList)
        {
            Console.WriteLine(character);
        }
        alphabetList.TrimExcess();
        FormattableString numchars = $"Number of characters: {alphabetList.Capacity}";
        Console.WriteLine(FormattableString.Invariant(numchars));
    }
}
