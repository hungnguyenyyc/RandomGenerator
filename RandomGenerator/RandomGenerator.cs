using System;
using System.Linq;

namespace RandomGenerator
{
    public class RandomGenerator
    {
        /*
            This is a considerbly big array (10000) for running random, and to loop and create random number one by one is not a good idea as in worst case scenario, it can run forever.
            So what we can do instead is to create an list of number than shuffle them, this way we can run the generator in O(n) assuming that the Random function run in O(1)
            Implement the "inside-out" algorithm
            https://en.wikipedia.org/wiki/Fisher%E2%80%93Yates_shuffle
        */
        public int[] Generate() {
            int length = 10000;
            int[] shuffled = new int[length];
            int[] unshuffled = Enumerable.Range(1, length).ToArray();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                int j = rnd.Next(i);
                if(j != i) {
                    shuffled[i] = shuffled[j];
                }
                shuffled[j] = unshuffled[i];
            }
            return shuffled;
        }
    }
}
