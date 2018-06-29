// AUTHOR: Luke Korsman
// FILENAME: Main.cs
// DATE: 26Apr2018
// VERSION: 1

// This file will call Driver.cs. Driver.cs contains the test functions for the
// EncryptWord class. Main.cs (this file) will interact with the user through
// the console and will call the Driver.cs file to perfrom its tests.

using System;

class Program
{
    // Entry point into the program
    public static void Main()
    {
        // Introduce the program to the user
        Console.WriteLine("This program tests the functionality and state "
                          + "changes of the encryptWord class. \nEach "
                          + "function will start by printing a message to the "
                          + "screen describing what \ntest is being performed."
                          + " Then the results of the test will be printed to "
                          + "the \nscreen as well.\n");   

        // Test object initial state
        Console.WriteLine("Testing the EncryptWord object initial state.");
        Console.WriteLine("All statistics should be set to 0's.");
        Console.WriteLine(DriverFile.Driver.testObjectInitialState());

        // Test end of alphabet encrypting properly
        Console.WriteLine("\nTesting x, y and z are encrypted properly as a, "
                          + "b and c respectively.");
        Console.WriteLine("Encrypting the word: xxyyzz");
        Console.WriteLine("Result: " 
                          + DriverFile.Driver.testEncryptEndOfAlphabet());

        // Tests Encrypt function with a word less than 4 characters
        Console.WriteLine("\nTesting the Encrypt function rejecting "
                          + "strings less than 4 characters.");
        Console.WriteLine("Trying to encrypt \"abc\"");
        Console.WriteLine("Result: " 
                          + DriverFile.Driver.testLessThan4CharInputWord());

        // Tests Encrypt function with a zero character string
        Console.WriteLine("\nTesting the Encrypt function rejecting "
                         + "strings of length 0.");
        Console.WriteLine("Trying to encrypt \"\"");
        Console.WriteLine("Result: " 
                          + DriverFile.Driver.testZeroCharInputWord());
        
        // Tests guessing a shift value lower than the SHIFT value
        Console.WriteLine("\nTesting a guess shift of 0.");
        Console.WriteLine(DriverFile.Driver.testLowGuessValue());

        // Tests guessing a shift value higher than the SHIFT value
        Console.WriteLine("\nTesting a guess shift of 4.");
        Console.WriteLine(DriverFile.Driver.testHighGuessValue());

        // Tests guessing a shift value equal to SHIFT value
        Console.WriteLine("\nTesting a guess shift of 3.");
        Console.WriteLine(DriverFile.Driver.testCorrectGuessValue());

        // Tests average guess value of DisplayGuessStatistics function
        Console.WriteLine("\nTesting average guess value of encryptWord.");
        Console.WriteLine("Guessing 2 and 5, average should be 3.");
        Console.WriteLine(DriverFile.Driver.testAverageGuessValue());

        // Tests resetting the EncryptWord object
        Console.WriteLine("\nTesting ResetObject function.");
        Console.WriteLine("Guessing 3 shift values, then resetting.");
        Console.WriteLine(DriverFile.Driver.testResetObject());


        int result = 123 % 122;
        char letter = (char)99;
        Console.WriteLine("27 % 26: " + result);
        Console.WriteLine("Char is: " + letter);
    }
}