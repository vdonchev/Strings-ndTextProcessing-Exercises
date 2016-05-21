namespace _12.CharacterMultiplier
{
    using System;

    public static class CharacterMultiplier
    {
        public static void Main()
        {
            var words = Console.ReadLine().Split();
            var res = MultiplyWords(words[0], words[1]);
            Console.WriteLine(res);
        }

        private static long MultiplyWords(string wordA, string wordB)
        {
            var minWord = wordA.Length > wordB.Length ? wordB : wordA;
            var maxWord = minWord == wordA ? wordB : wordA;

            long res = 0;
            for (int i = 0; i < minWord.Length; i++)
            {
                res += wordA[i] * wordB[i];
            }

            for (int i = minWord.Length; i < maxWord.Length; i++)
            {
                res += maxWord[i];
            }

            return res;
        }
    }
}