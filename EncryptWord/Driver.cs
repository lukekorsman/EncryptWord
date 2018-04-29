// AUTHOR: Luke Korsman
// FILENAME: Driver.cs
// DATE: 26Apr2018
// VERSION: 1

// This file contains functions which test the EncryptWord.cs file. Each 
// will test a different piece of code of the EncryptWord class.

using System;
using encryption;

namespace DriverFile
{
    public class Driver
    {
        // Test to ensure EncryptWord initialize properly
        public static string testObjectInitialState()
        {
            encryption.encryptWord initialState = new encryptWord();

            // Initial state will have all guess statistics as 0's
            return initialState.DisplayGuessStatistics();
        }

        // Test to ensure encryption works for x, y and z. 
        public static string testEncryptEndOfAlphabet()
        {
            encryption.encryptWord alphabetTest = new encryptWord();
            string testWord = "xxyyzz";

            // Returned string will be "aabbcc"
            return alphabetTest.Encrypt(testWord);
        }

        // Test to ensure strings less than 4 characters are rejected from
        // encrypting
        public static string testLessThan4CharInputWord()
        {
            encryption.encryptWord wordLength = new encryptWord();
            return wordLength.Encrypt("abc");
        }

        // Test to ensure strings of length 0 are rejected from encrypting
        public static string testZeroCharInputWord()
        {
            encryption.encryptWord wordLength = new encryptWord();
            return wordLength.Encrypt("");
        }

        // Test a low guess value. numberOfLowGuesses should increment and 
        // average guess value should update to guess value
        public static string testLowGuessValue()
        {
            encryption.encryptWord lowGuess = new encryptWord();
            lowGuess.GuessShiftValue(0);
            return lowGuess.DisplayGuessStatistics();
        }

        // Test a high guess value. numberOfHighGuesses should increment and 
        // average guess value should update to guess value
        public static string testHighGuessValue()
        {
            encryption.encryptWord highGuess = new encryptWord();
            highGuess.GuessShiftValue(4);
            return highGuess.DisplayGuessStatistics();
        }

        // Test a correct SHIFT value. numberOfQueries should increment and 
        // average guess value should update to guess value
        public static string testCorrectGuessValue()
        {
            encryption.encryptWord correctGuess = new encryptWord();
            correctGuess.GuessShiftValue(3);
            return correctGuess.DisplayGuessStatistics();
        }

        // Test average guess value is working correctly. The two guesses 
        // should be summed, divided by 2, then rounded down to the nearest
        // whole number
        public static string testAverageGuessValue()
        {
            encryption.encryptWord averageGuess = new encryptWord();
            averageGuess.GuessShiftValue(2);
            averageGuess.GuessShiftValue(5);
            return averageGuess.DisplayGuessStatistics();
        }

        // Test resetting the EncryptWord object. Input a low guess, high guess
        // and a correct guess. Then call ResetObject function. 
        // DisplayGuessStatistics function then should have all statistics set
        // to 0's.
        public static string testResetObject()
        {
            encryption.encryptWord resetTest = new encryptWord();
            resetTest.GuessShiftValue(0);
            resetTest.GuessShiftValue(3);
            resetTest.GuessShiftValue(5);
            resetTest.ResetObject();
            return resetTest.DisplayGuessStatistics();
        }
    }
}
