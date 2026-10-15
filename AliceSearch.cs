
using System;

class Program
{
    static void Main()
    {
        string aliceQuote =
            "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing " +
            "to do: once or twice she had peeped into the book her sister was reading, but it had no pictures " +
            "or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or " +
            "conversation?'";

        Console.WriteLine("What word do you wish to find:");

        string searchTerm = Console.ReadLine() ?? "";

        // INTENTIONAL BUG: The quote is converted to uppercase.
        string aliceLowerQuote = aliceQuote.ToLowerInvariant();
        // The search term is converted to lowercase.
        bool foundTerm = aliceLowerQuote.Contains(searchTerm.ToLowerInvariant());

        Console.WriteLine(
            $"It is {foundTerm} that the term {searchTerm} is within the quote."
        );
    }
}

/*
T7A - DEBUGGING PROCESS

1. I ran the program and searched for "Alice".
2. The program returned False, even though Alice appears in the quote.
3. I checked the ToUpperInvariant() and ToLowerInvariant()
   methods and found that they convert the text to different cases.
4. This caused the search to fail because Contains() is
   case-sensitive.
5. To fix the bug, I changed:
       aliceQuote.ToUpperInvariant()
   to:
       aliceQuote.ToLowerInvariant()
6. I ran the program again and searched for "Alice".
   It returned True, confirming that the bug was fixed.

The lesson: Read the output, inspect the relevant lines,
identify the cause, fix the code, and test it again.
*/