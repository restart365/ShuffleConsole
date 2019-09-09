using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Shuffle
{
    class Program
    {
        #region Shuffle
        
        /*
         * Utilizing the idea of Fisher-Yates Shuffle, switch the ith number with the random
         * jth number. i is decreasing from (length - 1) of list, 0 <= j < i
        */
        private static List<int> FisherYatesShuffle(List<int> list)
        {
            var i = list.Count() - 1;
            var rnd = new Random();

            while (i > 1)
            {
                var j = rnd.Next(i + 1); //.Net Random.Next(n) returns a number in [0,n).
                
                var temp = list[j];
                list[j] = list[i];
                list[i] = temp;

                i--;
            }

            return list;
        }

        #endregion

        #region Run

        public static readonly int LIST_SIZE = 10000;

        static void Main()
        {
            var randomList = Enumerable.Range(1, LIST_SIZE).ToList();

            randomList = FisherYatesShuffle(randomList);

            // Debugging
            Debug.Assert(randomList.Count() == LIST_SIZE);
            Debug.Assert(randomList.Distinct().Count() == randomList.Count());

            var output = string.Join(", ", randomList);
            Console.WriteLine(output);
        }

        #endregion

    }
}
