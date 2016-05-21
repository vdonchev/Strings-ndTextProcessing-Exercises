namespace _11.Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class Palindromes
    {
        public static void Main()
        {
            string[] words = Console.ReadLine()
                .Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            var palindromes = new SortedSet<string>();

            foreach (var word in words)
            {
                if (word.SequenceEqual(word.Reverse()))
                {
                    palindromes.Add(word);
                }
            }

            Console.WriteLine($"[{string.Join(", ", palindromes)}]");
        }
    }
}