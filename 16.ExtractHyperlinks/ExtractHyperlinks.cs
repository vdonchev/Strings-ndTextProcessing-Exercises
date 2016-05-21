namespace _16.ExtractHyperlinks
{
    using System;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;

    public static class ExtractHyperlinks
    {
        public static void Main()
        {
            StringBuilder text = new StringBuilder();
            string command = Console.ReadLine();
            while (command != "END")
            {
                text.AppendLine(command);
                command = Console.ReadLine();
            }

            MatchCollection matches = Regex.Matches(text.ToString(), @"<a[^>]*?href\s*=\s*(?:(?:""\s*(?<catch>[^\""]+)"")|(?:\'\s*(?<catch>[^\']+)\')|(?:(?<catch>[^\s]+)))");
            matches.Cast<Match>().Select(i => i.Groups["catch"]).ToList().ForEach(Console.WriteLine);
        }
    }
}