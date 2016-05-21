namespace _01.ReverseString
{
    using System;
    using System.Linq;

    static class ReverseString
    {
        static void Main()
        {
            string str = Console.ReadLine();
            Console.WriteLine(string.Join("", str.ToCharArray().Reverse()));
        }
    }
}
