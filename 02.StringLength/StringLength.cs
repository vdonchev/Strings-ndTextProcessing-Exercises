namespace _02.StringLength
{
    using System;

    public static class StringLength
    {
        public static void Main()
        {
            string str = Console.ReadLine();
            str = (str.Length > 20) ? str.Substring(0, 20) : str.PadRight(20, '*');
            Console.WriteLine(str);
        }
    }
}