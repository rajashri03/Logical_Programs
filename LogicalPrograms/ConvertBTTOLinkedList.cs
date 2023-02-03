using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    internal class ConvertBTTOLinkedList
    {
        // Function to print the linked list
        public static void print(Node head)
        {
            if (head == null)
            {
                return;
            }
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        public static Node sortedList(Node head, treeNode root)
        {
            if (root == null)
            {
                return head;
            }

            head = sortedList(head, root.left);
            Node newNode = new Node(root.data);
            Node temp = head;
            Node prev = null;

            if (temp == null)
            {
                head = newNode;
            }
            else
            {

                while (temp != null)
                {
                    if (temp.data > root.data)
                    {
                        break;
                    }
                    else
                    {
                        prev = temp;
                        temp = temp.next;
                    }
                }

                if (temp == null)
                {
                    prev.next = newNode;
                }
                else
                {
                    if (prev == null)
                    {
                        newNode.next = temp;
                        head = newNode;
                    }
                    else
                    {
                        newNode.next = temp;
                        prev.next = newNode;
                    }
                }
            }

            head = sortedList(head, root.right);
            return head;
        }
    }
}
