// AUTHOR: Luke Korsman
// FILENAME: EncryptWord.cs
// DATE: 14Apr2018
// VERSION: 1

// IMPLEMENTATION INVARIANTS: Encrypt function will only encrypt English 
// alphabetical characters. Initializing an EncryptWord object initially sets 
// the encryption 'off'. The Encrypt function turns the object 'on' and the decrypt 
// function turns the object 'off'. 'On' is defined as calling the encrypt function. 
// Encrypted means encoding a string using a positive Caesar cipher shift
// (example: 'a' goes to 'd'). 'Off' means the encryptWord object has been reset
// or the the Encrypt function has not been called. Resetting the object is 
// defined as setting numberOfQueries, numberOfHighGuesses, numberOfLowGuesses 
// and sumOfGuesses to 0 and the encryptWord 'off'. numberOfQueries is defined as 
// the number of times the GuessShiftValue function is called, meaning 
// numberOfQueries increments when an integer value of 0 or greater is passed in
// as the parameter to the GuessShiftValue function. Every call to the 
// GuessShiftValue function with a non-negative value will either increment 
// numberOfHighGuesses, numberOfLowGuesses or neither based on the passed in 
// integer value. sumOfGuesses keeps the sum total of every non-negative value 
// passed into the GuessShiftValue function unless the EncryptWord object is 
// reset. sumOfGuesses divided by numberOfQueries drives the average guess value
// in DisplayGuessStatistics function. numberOfHighGuesses is defined as an 
// integer passed into the GuessShiftValue function that is greater than the 
// SHIFT constant. numberOfLowGuesses is defined as an integer passed into the 
// GuessShiftValue function that is lower than the SHIFT constant. 
// ASSUMPTIONS
// 1. The string passed into the Encrypt function should be lowercase letters
// 2. Lowercase letters should be encoded/decoded as other lowercase letters.
// 3. Non-alphabetical characters will not correctly encrypt
// 4. The DisplayGuessStatistics will return a string containing 
//    numberOfQueries, numberOfHighGuesses, numberOfLowGuesses and the average
//    guess value when called.
// 5. The EncryptWord object will initially be set to 'off'.
// 6. The encrypt function turns the EncryptWord object 'on'.
// 7. Strings passed into the encrypt function that are less than 4 characters
//    should be rejected.

using System;

namespace encryption
{
    public class encryptWord
    {
        private const int SHIFT = 3;        // Caesar shift value
        private uint numberOfQueries;       // Total number of guesses of SHIFT
        private uint numberOfHighGuesses;   // Number of guesses higher than SHIFT
        private uint numberOfLowGuesses;    // Number of guesses lower than SHIFT
        private uint sumOfGuesses;          // Total number of SHIFT guesses
        private string word;                // Holds the word to be encrypted

        // Description: Constructor of the object. Sets the numberOfQueries, 
        // numberOfHighGuesses, numberOfLowGuesses and sumOfGuesses to 0.
        // Precondition: None
        // Postcondition: EncryptWord object is off.
        public encryptWord()
        {
            numberOfQueries = 0;
            numberOfHighGuesses = 0;
            numberOfLowGuesses = 0;
            sumOfGuesses = 0;
        }

        // Description: Encrypts/encodes the word passed in as a parameter.
        // Precondition: EncryptWord object must be off. The string passed
        // into the constructor as a parameter must of length 4 or longer and 
        // must be alphabetical lowercase characters only.
        // Postcondition: EncryptWord object is on.
        public string Encrypt(string originalWord)
        {
            char letter;                    // Current letter of the buffer array
            word = originalWord.ToLower();  // set encryptWord word variable to 
                                            // lowercase inputted word
            char[] buffer = word.ToCharArray(); // create a character array 
                                                // based on inputted word

            if (word.Length < 4 || word.Length == 0) // Check if word length is 
                                                     // < 4 characters 
            {
                return "Error, the word must be 4 characters or longer.";
            }
            else // originalWord is longer than 4 characters
            {
                // Loop through buffer array updating characters based on SHIFT
                for (int i = 0; i < buffer.Length; i++)
                {
                    letter = buffer[i];
                    letter = (char)(letter + SHIFT);

                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    buffer[i] = letter; // Update buffer index with new letter
                }
                return new string(buffer); // Return encrypted string
            }
        }

        // Description: Allows a user to guess the SHIFT value. Returns 
        // the boolean true if the integer passed in as a parameter is the 
        // SHIFT, false if not.
        // Precondition: The value passed as the parameter must be a positive 
        // non-zero integer.
        // Postcondition: numberOfQueries, numberOfHighGuesses, 
        // numberOfLowGuesses will increase based on the input value. 
        // sumOfGuesses will change values.
        public bool GuessShiftValue(uint guess)
        {

            numberOfQueries++;      // Increment number of guesses/queries
            sumOfGuesses += guess;  // Add guess value to the sum of guesses

            // Check if guess equals SHIFT value
            if (guess == SHIFT)
            {
                return true;
            }
            // Check if guess is lower than SHIFT value
            else if (guess < SHIFT)
            {
                numberOfLowGuesses++;
                return false;
            }
            // Check if guess is higher than SHIFT value
            else
            {
                numberOfHighGuesses++;
                return false;
            }
        }

        // Description: Returns a string displaying the number of guesses of
        // the SHIFT, number of high guesses, low guesses, and average
        // guess value.
        // Precondition: None
        // Postcondition: None
        public string DisplayGuessStatistics()
        {
            string result = ""; // Create an empty string to hold return string
            uint avgGuess;      // Holds the average SHIFT guess value

            // Check if the number of guesses is zero to avoid divide by zero
            if (numberOfQueries == 0)
            {
                avgGuess = 0;
            }
            // Calculate average guess value
            else
            {
                avgGuess = sumOfGuesses / numberOfQueries;
            }

            // Concatenate the guess statistics in a readable string
            result = "Guesses: " + numberOfQueries.ToString() + " High Guesses: " +
                    numberOfHighGuesses.ToString() + " Low Guesses: " +
                    numberOfLowGuesses.ToString() + " Average Guess Value: " +
                    avgGuess.ToString();

            return result;
        }

        // Description: Resets the numberOfQueries, numberOfHighGuesses, 
        // numberOfLowGuesses and sumOfGuess. Sets encryptWord 'off'.
        // Precondition: None
        // Postcondition: numberOfQueries, numberOfHighGuesses, 
        // numberOfLowGuesses and sumOfGuess are set to 0. EncryptWord is 'off'.
        public void ResetObject()
        {
            numberOfQueries = 0;
            numberOfHighGuesses = 0;
            numberOfLowGuesses = 0;
            sumOfGuesses = 0;
        }
    }
}
