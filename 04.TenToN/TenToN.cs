namespace _04.TenToN
{
    using System;
    using System.Linq;
    using System.Numerics;
    using System.Text;

    public static class TenToN
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().Select(BigInteger.Parse).ToArray();
            var numeralSys = input[0];
            var num = input[1];
            var converted = ConvertFromTenToN(numeralSys, num);
            Console.WriteLine(converted);
        }

        private static string ConvertFromTenToN(BigInteger numeralSys, BigInteger num)
        {
            StringBuilder res = new StringBuilder();
            while (num > 0)
            {
                res.Insert(0, num % numeralSys);
                num /= numeralSys;
            }

            return res.ToString();
        }
    }
}
