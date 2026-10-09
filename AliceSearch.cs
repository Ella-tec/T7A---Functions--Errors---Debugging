using System;

public class AliceWordSearch
{
    public static void Main(string[] args)
    {
        // Declare variables we will need
        string aliceQuote = (
            "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing " +
            "to do: once or twice she had peeped into the book her sister was reading, but it had no pictures " +
            "or conversations in it, ‘and what is the use of a book,’ thought Alice ‘without pictures or " +
            "conversation?’"
        );

        Console.WriteLine("What word do you wish to find:");
        string searchTerm = Console.ReadLine() ?? string.Empty;

        string aliceLowerQuote = aliceQuote.ToLowerInvariant();
        bool foundTerm = aliceLowerQuote.Contains(searchTerm.ToLowerInvariant());

        // Respond to search
        Console.WriteLine($"It is {foundTerm} that the term {searchTerm} is within the quote.");

        // Extension exercise
        // assume word is in sentence
        // print out its index
        // remove word from string and reprint

        if (string.IsNullOrEmpty(searchTerm))
        {
            Console.WriteLine("No search term entered.");
            return;
        }

        int index = aliceLowerQuote.IndexOf(searchTerm.ToLowerInvariant(), StringComparison.Ordinal);

        if (index >= 0)
        {
            Console.WriteLine(
                $"You first find this word in the {index} character's position of the quote, as seen below."
            );

            Console.WriteLine(
                aliceQuote.Substring(0, index) +
                "[" + searchTerm.ToUpperInvariant() + "]" +
                aliceQuote.Substring(index + searchTerm.Length)
            );
        }
        else
        {
            Console.WriteLine("The word was not found in the quote.");
        }
    }
}
