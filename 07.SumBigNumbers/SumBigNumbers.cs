namespace _07.SumBigNumbers
{
    using System;
    using System.Linq;
    using System.Text;

    public static class SumBigNumbers
    {
        public static void Main()
        {
            var numA = string.Join("", Console.ReadLine().Reverse());
            var numB = string.Join("", Console.ReadLine().Reverse());
            var sum = SumNums(numA, numB);
            Console.WriteLine(sum);
        }

        private static string SumNums(string numA, string numB)
        {
            var sum = new StringBuilder();
            byte additional = 0;
            for (int i = 0; i < Math.Max(numA.Length, numB.Length); i++)
            {
                byte top = i < numA.Length ? (byte) (numA[i] - '0') : (byte) 0;
                byte bottom = i < numB.Length ? (byte) (numB[i] - '0') : (byte) 0;

                byte current = (byte) (top + bottom + additional);

                if (current > 9)
                {
                    additional = (byte) (current / 10);
                    sum.Insert(0, current - 10);
                }
                else
                {
                    sum.Insert(0, current);
                    additional = 0;
                }
            }

            sum.Insert(0, additional);

            return sum.ToString().TrimStart('0');
        }
    }
}