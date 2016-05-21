namespace _05.NToTen
{
    using System;
    using System.Numerics;

    public static class NToTen
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var numeralSys = byte.Parse(input[0]);
            var num = input[1];
            Console.WriteLine(ConvertNToTen(numeralSys, num));
        }

        private static BigInteger ConvertNToTen(byte numeralSys, string num)
        {
            BigInteger decimalNum = 0;
            for (int i = num.Length - 1, pow = 0; i >= 0; i--, pow++)
            {
                decimalNum += int.Parse(num[i].ToString()) * BigInteger.Pow(numeralSys, pow);
            }

            return decimalNum;
        }
    }
}
