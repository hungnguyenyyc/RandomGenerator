using System;

namespace RandomGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator g = new RandomGenerator();
            int[] shuffled = g.Generate();
            for (int i = 0; i < shuffled.Length; i++)
            {
                Console.WriteLine(shuffled[i]);
            }
        }
    }
}