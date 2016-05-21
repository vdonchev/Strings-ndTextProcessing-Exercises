namespace _06.CountSubstringOccurrences
{
    using System;

    public static class CountSubstringOccurrences
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string needle = Console.ReadLine();

            int index = 0;
            int matches = 0;

            while (true)
            {
                if (text.IndexOf(needle, index) < 0) break;

                index = text.IndexOf(needle, index, StringComparison.InvariantCultureIgnoreCase) + 1;
                matches++;
            }

            Console.WriteLine(matches);
        }
    }
}