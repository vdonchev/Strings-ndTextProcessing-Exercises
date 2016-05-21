namespace _03.FormattingNumbers
{
    using System;
    using System.Text.RegularExpressions;

    public static class FormattingNumbers
    {
        public static void Main()
        {
            var nums = Regex.Split(Console.ReadLine(), @"\s+");

            var a = int.Parse(nums[0]);
            var b = double.Parse(nums[1]);
            var c = double.Parse(nums[2]);

            Console.WriteLine(
                "|{0,-10:X}|{1,10}|{2,10:f2}|{3,-10:0.000}|",
                a,
                Convert.ToString(a, 2).PadLeft(10, '0').Substring(0, 10),
                b,
                c);
        }
    }
}
