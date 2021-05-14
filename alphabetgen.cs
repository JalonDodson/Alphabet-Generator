using System;
using System.Linq;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        // userInput variable to grab user's input, alphabet/alphabetlist variable to initialize list of letters
        string userInput;
        string[] alphabet = {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
            };
        List<string> alphabetList = new(alphabet);
        // loops until the user enters a string that is within 1-256 characters
        while (true)
        {
            Console.WriteLine("Input string (up to 256 characters): ");
            userInput = Console.ReadLine();
            if (userInput.Length > 256 || userInput.Length == 0)
            {
                Console.WriteLine("Invalid string length (1-256 characters). ");
            }
            else
            {
                break;
            }
        }
        // loops through user's input and checks if the current index(i) is in the alphabet list, removes if so
        for (int i = 0; i < userInput.Length; i++)
        {
            if (alphabetList.Contains(userInput[i].ToString().ToLower()))
            {
                alphabetList.Remove(userInput[i].ToString().ToLower());
            }
        }
        
        Console.WriteLine("Letters not in user's input:");
        // loops through alphabet list (after removal of letters from user's input) and writes them to the console
        foreach (string letter in alphabetList)
        {
            Console.WriteLine(letter);
        }
        // removes excess (empty) space from alphabet list, writes the new capacity to the console
        alphabetList.TrimExcess();
        FormattableString numchars = $"Number of characters: {alphabetList.Capacity}";
        Console.WriteLine(FormattableString.Invariant(numchars));
    }
}
