using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nEnter the option to perform the operation \n1) Pair Intersection \n2) Vending machine\n3)Permutation of string\n" +
                    "4)Convert binary to linked list");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        int[] Pair1 = new int[2];
                        int[] Pair2 = new int[2];
                        PairIntersection.arrayInput(Pair1);
                        PairIntersection.arrayInput(Pair2);
                        int[] resultPair = PairIntersection.Pair_Intersection(Pair1, Pair2);
                        Console.WriteLine("[{0}]", string.Join(", ", resultPair));
                        break;
                    case 2:
                        VendingMachine machine = new VendingMachine();
                        machine.MinNumberOfNote(5);

                        break;
                    case 3:
                        string str = "XYZ";
                        int n = str.Length;
                        Permutation.permute(str, 0, n - 1);
                        break;
                    case 4:
                        treeNode root = new treeNode(6);
                        root.left = new treeNode(2);
                        root.right = new treeNode(8);
                        root.left.left = new treeNode(1);
                        root.left.right = new treeNode(4);
                        root.right.left = new treeNode(7);
                        root.right.right = new treeNode(9);
                        root.left.right.left = new treeNode(3);
                        root.left.right.right = new treeNode(5);

                        Node head = ConvertBTTOLinkedList.sortedList(null, root);
                        ConvertBTTOLinkedList.print(head);
                        break;

                }
            }
        }

    }
}
