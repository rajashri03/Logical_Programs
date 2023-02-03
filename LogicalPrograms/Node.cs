using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    //Linked list node
    internal class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    //Binary tree node
    class treeNode
    {
        public int data;
        public treeNode left;
        public treeNode right;
        public treeNode(int data)
        {
            this.data = data;
            this.left = null;
            this.right = null;
        }
    };
}
