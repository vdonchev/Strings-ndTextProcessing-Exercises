namespace _14.LettersChangeNumbers
{
    using System;
    using System.Linq;
    using System.Threading;

    public static class LettersChangeNumbers
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                System.Globalization.CultureInfo.InvariantCulture;
            char[] separators = { ' ', '\t' };
            string[] words = Console.ReadLine().Split(separators,
                StringSplitOptions.RemoveEmptyEntries).Select(p => p.Trim()).ToArray();

            double sum = 0.0;
            foreach (string word in words)
            {
                char prefix = word[0];
                char suffix = word[word.Length - 1];
                double number = double.Parse(word.Substring(1, word.Length - 2));

                if (char.IsUpper(prefix))
                    number /= 1.00 * (prefix - 'A' + 1);
                else
                    number *= 1.00 * (prefix - 'a' + 1);

                if (char.IsUpper(suffix))
                    number -= (suffix - 'A' + 1);
                else
                    number += (suffix - 'a' + 1);

                sum += number;
            }

            Console.WriteLine("{0:F2}", sum);
        }
    }
}