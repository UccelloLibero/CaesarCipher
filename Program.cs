using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      // Capture users input secret message
      Console.Write("What is your secret message? ");
      string usersMessage = Console.ReadLine();

      Console.WriteLine(usersMessage);

      // Convert captured users input into an array of characters
      char[] secretMessage = usersMessage.ToCharArray();

      // An empty array of characters to hold the encrypted message
      char[] encryptedMessage = new char[secretMessage.Length];

      // Preform encryption for every letter in the users message
      // Loop through each char in secretMessage
      for (int i = 0; i < secretMessage.Length; i++)
      {
        // access the char position in the secretMessage array
        char letter = secretMessage[i];
        // find position of the char in the alphabet array
        int letterPosition = Array.IndexOf(alphabet, letter);
        // add 3 to the letter positon, assign to a new variable
        // (handle System.IndexOutOfRangeException error when encrypting letter z)
        int newLetterPosition = (letterPosition + 3) % alphabet.Length;
        // find new encrypted char with new positon
        char letterEncoded = alphabet[newLetterPosition];

        // add the encrypted char to the array encryptedMessage
        encryptedMessage[i] = letterEncoded;
      }

      // Convert the encrypted char array to a string
      string encodedMessage = String.Join("", encryptedMessage);
      Console.WriteLine(encodedMessage);

    }
  }
}
