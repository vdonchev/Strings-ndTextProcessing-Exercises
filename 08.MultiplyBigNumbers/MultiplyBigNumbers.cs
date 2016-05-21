namespace _08.MultiplyBigNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public static class MultiplyBigNumbers
    {
        public static void Main()
        {
            // Wrong Zero test
            // BigInteger aa = BigInteger.Parse("923847238931983192462832102");
            // Console.WriteLine(aa * 4);

            var numA = string.Join("", Console.ReadLine());
            var numB = string.Join("", Console.ReadLine());
            var multiplied = Multiply(numB, numA);
            Console.WriteLine(multiplied == string.Empty ? "0" : multiplied);
        }

        private static string Multiply(string numA, string numB)
        {
            var subSums = new List<string>();

            byte a = (byte)(numA[0] - '0');
            var index = 0;
            for (int i = numB.Length - 1; i >= 0; i--)
            {
                var curr = numB[i];
                byte b = (byte)(curr - '0');
                var mul = a * b;
                subSums.Add(mul + new string('0', index));
                index++;
            }

            var total = "0";
            for (int i = 0; i < subSums.Count; i++)
            {
                total = SumNums(total, subSums[i]);
            }

            return total;
        }

        private static string SumNums(string numA, string numB)
        {
            numA = string.Join("", numA.Reverse());
            numB = string.Join("", numB.Reverse());

            var sum = new StringBuilder();
            byte additional = 0;
            for (int i = 0; i < Math.Max(numA.Length, numB.Length); i++)
            {
                byte top = i < numA.Length ? (byte)(numA[i] - '0') : (byte)0;
                byte bottom = i < numB.Length ? (byte)(numB[i] - '0') : (byte)0;

                byte current = (byte)(top + bottom + additional);

                if (current > 9)
                {
                    additional = (byte)(current / 10);
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
