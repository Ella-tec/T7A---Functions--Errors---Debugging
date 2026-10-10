string aliceQuote = (
    "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing " +
    "to do: once or twice she had peeped into the book her sister was reading, but it had no pictures " +
    "or conversations in it, ‘and what is the use of a book,’ thought Alice ‘without pictures or " +
    "conversation?’"
);

Console.WriteLine("What word do you wish to find:");
string searchTerm = Console.ReadLine();

string aliceLowerQuote = aliceQuote.ToLowerInvariant();
bool foundTerm = aliceLowerQuote.Contains(searchTerm.ToLowerInvariant());

Console.WriteLine($"It is {foundTerm} that the term {searchTerm} is within the quote.");