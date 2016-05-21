namespace _13.MagicExchangeableWords
{
    using System;
    using System.Collections.Generic;

    public static class MagicExchangeableWords
    {
        static void Main()
        {
            var mapA = new Dictionary<char, char>();
            var mapB = new Dictionary<char, char>();

            var words = Console.ReadLine().Split();
            var wordA = words[0];
            var wordB = words[1];

            var shorterWord = wordA.Length < wordB.Length ? wordA : wordB;
            var longerWord = wordA == shorterWord ? wordB : wordA;

            for (int i = 0; i < shorterWord.Length; i++)
            {
                var chA = shorterWord[i];
                var chB = longerWord[i];

                if (!mapA.ContainsKey(chA) && !mapB.ContainsKey(chB))
                {
                    mapA.Add(chA, chB);
                    mapB.Add(chB, chA);
                }
                else if (mapA.ContainsKey(chA) && mapB.ContainsKey(chB))
                {
                    if (mapA[chA] != chB || mapB[chB] != chA)
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("false");
                    return;
                }
            }

            if (longerWord.Length != shorterWord.Length)
            {
                for (int i = shorterWord.Length; i < longerWord.Length; i++)
                {
                    if (!mapB.ContainsKey(longerWord[i]))
                    {
                        Console.WriteLine("false");
                        return;
                    }
                }
            }

            Console.WriteLine("true");
        }
    }
}
