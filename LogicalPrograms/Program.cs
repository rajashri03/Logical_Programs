using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VendingMachine machine = new VendingMachine();
            machine.MinNumberOfNote(5);

            string str = "XYZ";
            int n = str.Length;
            Permutation.permute(str, 0, n - 1);
        }
    }
}
