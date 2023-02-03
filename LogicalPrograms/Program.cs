using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //VendingMachine machine = new VendingMachine();
            //machine.MinNumberOfNote(5);

            //string str = "XYZ";
            //int n = str.Length;
            //Permutation.permute(str, 0, n - 1);

            int[] Pair1 = new int[2];
            int[] Pair2 = new int[2];
            PairIntersection.arrayInput(Pair1);
            PairIntersection.arrayInput(Pair2);
            int[] resultPair = PairIntersection.Pair_Intersection(Pair1, Pair2);
            Console.WriteLine("[{0}]", string.Join(", ", resultPair));
        }
    }
}
