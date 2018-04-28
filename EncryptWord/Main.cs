

using System;
using encryption;

class Program
{
    static void Main()
    {
        // FIXME move welcome message to main
        DriverFile.Driver.welcomeMessage();



        // Test object initial state


        // Test end of alphabet encrypting properly
        Console.WriteLine("\nThis will test the cipher value wrapping encryption back to the "
        + "start of the \nalphabet. For example a 'z' will be encrypted as a "
        + "letter at the beginning \nof the lowercase alphabet. This will "
                  + "also test uppercase letters the same way.\n");
        Console.WriteLine("Encrypting the word: ZzXx");
        Console.WriteLine("Result: " + DriverFile.Driver.testEncryptEndOfAlphabet());



        /*
        encryption.encryptWord one = new encryptWord();
        string returnWord = one.Encrypt("abcxyz");

        Console.WriteLine("Original word was 'Hello', encrypted is " + returnWord);

        Console.WriteLine("Guessing shift of 3; " + one.GuessShiftValue(3));
        Console.WriteLine("Guessing shift of 1; " + one.GuessShiftValue(1));
        Console.WriteLine("Guessing shift of 0; " + one.GuessShiftValue(0));
        Console.WriteLine("Guessing shift of 5; " + one.GuessShiftValue(5));

        Console.WriteLine("Displaying stats: " + one.DisplayGuessStatistics());
        one.resetEncryption();
        Console.WriteLine("RESET Displaying stats: " + one.DisplayGuessStatistics());

        Console.WriteLine("Hello World!");
        */

        // Keep the console window open in debug mode.
        //Console.WriteLine("Press any key to exit.");
        //Console.Read();
    }
}