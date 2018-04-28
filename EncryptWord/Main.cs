

using System;
using encryption;

class Program
{
    public static void WelcomeMessage()
    {
        Console.WriteLine("This program tests the functionality and state changes of the "
                + "encryptWord class. \nEach function will start by printing a "
                + "message to the screen describing what \ntest is being performed. "
                + "Then the results of the test will be printed to the \nscreen as "
                          + "well.\n");
    }

    public static void Main()
    {
        WelcomeMessage();

        // Test object initial state
        Console.WriteLine("This will test the EncryptWord object initial state."
                          + " If successful, EncryptWord's \nnumberOfQueries, "
                          + "numberOfHighGuesses, numberOfLowGuesses, and "
                          + "sumOfGuesses should \nbe 0.");
        Console.WriteLine(DriverFile.Driver.testObjectInitialState());


        // Test end of alphabet encrypting properly
        Console.WriteLine("\nThis will test the cipher value wrapping encryption back to the "
        + "start of the \nalphabet. For example a 'z' will be encrypted as a "
        + "letter at the beginning \nof the lowercase alphabet.\n");
        Console.WriteLine("Encrypting the word: xxyyzz");
        Console.WriteLine("Result: " + DriverFile.Driver.testEncryptEndOfAlphabet());

        // Tests Encrypt function with a word less than 4 characters
        Console.WriteLine("\nThis will test calling the Encrypt function with a "
                          + "string less than 4 characters. \nAn error message "
                          + "should be return rather than an encrypted word.");
        Console.WriteLine("Result: " + DriverFile.Driver.testLessThan4CharInputWord());

    }
}