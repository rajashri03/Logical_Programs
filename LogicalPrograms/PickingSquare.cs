using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class PickingSquare
    {
        public static void findingSquares(int[] Input)
        {
            List<int> Output = new List<int>();
            for (int i = 0; i < Input.Length; i++)
            {
                for (int j = 0; j < Input[i]; j++)
                {
                    if (Input[i] == j * j)
                    {
                        Output.Add(Input[i]);
                    }

                }
            }
          Output.Sort();
            Console.Write("[");
            foreach (int i in Output)
            {
               
                Console.Write(i +" ");
            }
            Console.Write("]");
        }
    }
}
