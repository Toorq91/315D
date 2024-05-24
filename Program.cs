public class Ord
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please write some words here: ");
            string input = Console.ReadLine();
            string wordLength = WordLength(input);
            int counts = wordLength.Count();
            string[] words = input.Split(' ');
            int wordCounter = words.Count();
            int longestWord = LongestWordLength(input);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You typed:");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{counts} chars");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{wordCounter} words");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"Biggest word is {longestWord} chars. \n");

        }
    }

    static string WordLength(string word)
    {
        char[] charArray = word.ToCharArray();
        return new string(charArray);
    }

    static int LongestWordLength(string input)
    {
        string[] words = input.Split(' ');
        var maxLength = 0;

        foreach (var word in words)
        {
            if (word.Length > maxLength)
            {
                maxLength = word.Length;
            }
        }
        return maxLength;
    }
}