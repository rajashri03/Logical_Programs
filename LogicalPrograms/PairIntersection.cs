using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class PairIntersection
    {
        public static void arrayInput(int[] a)
        {
            Console.WriteLine("Enter the pair of Elements:");
            for (int j = 0; j <= 1; j++)
            {
                a[j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static int[] Pair_Intersection(int[] Pair1, int[] Pair2)
        {

            int[] Pair3 = new int[2];
            int[] Pair4 = new int[Pair1.Length + Pair2.Length];
            
            if (Pair2[0] <= Pair1[1])
            {
                Pair3[0] = Pair2[0];
                Pair3[1] = Pair1[1];
                return Pair3;
            }
            else
            {
                Console.WriteLine("They dont have similar values");
            }
            return null;
        }


    }
}
