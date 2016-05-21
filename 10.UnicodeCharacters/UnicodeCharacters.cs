namespace _10.UnicodeCharacters
{
    using System;

    public static class UnicodeCharacters
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            foreach (var ch in text)
            {
                Console.Write("\\u" + ((int)ch).ToString("x4"));
            }

            Console.WriteLine();
        }
    }
}