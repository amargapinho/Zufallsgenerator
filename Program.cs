using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Zufallsgenerator
{
    class Program
    {
        static void Main(string[] args)

        {
            int N = 5;
            int b = 7;
            int m = 9;

            int seed = 78;

            List<int> a = new List<int>();
            a.Add(seed);

            for(int i = 1; i < N; i++)
            {
                a.Add((a.ElementAt(i - 1) * b + 1) % m);
                Console.WriteLine(a.ElementAt(i));
            }

            Console.WriteLine(seed);


   
        }
    }
}