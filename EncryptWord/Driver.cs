// AUTHOR: Luke Korsman
// FILENAME: driver.cs
// DATE: 26Apr2018
// VERSION: 1

using System;
using encryption;

namespace DriverFile
{
    public class Driver
    {
        public static void welcomeMessage()
        {
            Console.WriteLine("\nThis program tests the functionality and state changes of the "
                    + "encryptWord class. \nEach function will start by printing a "
                    + "message to the screen describing what \ntest is being performed. "
                    + "Then the results of the test will be printed to the \nscreen as "
                              + "well.\n");
        }

        public static string testEncryptEndOfAlphabet()
        {
            encryption.encryptWord alphabetTest = new encryptWord();
            string testWord = "ZzXx";

            return alphabetTest.Encrypt(testWord);
        }

        public static string testObjectInitialState()
        {
            encryption.encryptWord initialState = new encryptWord();
            return initialState.DisplayGuessStatistics();


            // TEST COMMENT FOR GITHUB
        }

    }

}
