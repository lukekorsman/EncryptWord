// AUTHOR: Luke Korsman
// FILENAME: Driver.cs
// DATE: 26Apr2018
// VERSION: 1

using System;
using encryption;

namespace DriverFile
{
    public class Driver
    {
        public static string testObjectInitialState()
        {
            encryption.encryptWord initialState = new encryptWord();
            return initialState.DisplayGuessStatistics();
        }

        public static string testEncryptEndOfAlphabet()
        {
            encryption.encryptWord alphabetTest = new encryptWord();
            string testWord = "xxyyzz";

            return alphabetTest.Encrypt(testWord);
        }

        public static string testLessThan4CharInputWord()
        {
            encryption.encryptWord wordLength = new encryptWord();
            return wordLength.Encrypt("abc");
        }

        public static string testZeroCharInputWord()
        {
            encryption.encryptWord wordLength = new encryptWord();
            return wordLength.Encrypt("");
        }

        public static string testLowGuessValue()
        {
            encryption.encryptWord lowGuess = new encryptWord();
            lowGuess.GuessShiftValue(0);
            return lowGuess.DisplayGuessStatistics();
        }

        public static string testHighGuessValue()
        {
            encryption.encryptWord highGuess = new encryptWord();
            highGuess.GuessShiftValue(4);
            return highGuess.DisplayGuessStatistics();
        }

        public static string testCorrectGuessValue()
        {
            encryption.encryptWord correctGuess = new encryptWord();
            correctGuess.GuessShiftValue(3);
            return correctGuess.DisplayGuessStatistics();
        }

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
