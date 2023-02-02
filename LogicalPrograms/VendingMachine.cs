using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    public class VendingMachine
    {
        public void MinNumberOfNote(int change)
        {
            int[] arr = { 100,50,25,10,5,1 };
            int[] notes = new int[6];
            int count = 0;
            Console.Write("[");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] +", ");
            }
            Console.Write("]");
            Console.WriteLine("\n");
            Console.WriteLine("input is " + change);
            for (int i = 0; i < arr.Length; i++)
            {
                while (change / arr[i] != 0)
                {
                        notes[i] = ++count;
                        change %= arr[i];
                  
                }
                count = 0;
            }
            Console.Write("[");
            for (int i = 0; i < notes.Length; i++)
            {
                count += notes[i];
                Console.Write(notes[i]+",");
            }
            Console.Write("]");
            Console.WriteLine("\n");
            Console.WriteLine("total number of minimum notes needed to return change " + count);
            Console.WriteLine(" ");
        }
    }
}
