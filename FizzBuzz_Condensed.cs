for (int i = 1; i <= 20; i++)
{
    string output = (i % 3 == 0 ? "Fizz" : "") + (i % 5 == 0 ? "Buzz" : "");
    Console.WriteLine(string.IsNullOrEmpty(output) ? i.ToString() : output);
}