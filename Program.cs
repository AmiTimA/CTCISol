using System;

namespace CTCISol
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Node node1 = new Node();
            node1.value = 1;
            Node node2 = new Node();
            node2.value = 2;
            Node node3 = new Node();
            node3.value = 3;
            Node node4 = new Node();
            node4.value = 4;
            Node node5 = new Node();
            node5.value = 5;

            node1.left = node2;
            node1.right = node3;
            node2.left = node4;
            node2.right = node5;
            
            Console.WriteLine(SumOfBinaryTree(node1));
        }

        static int SumOfBinaryTree(Node node)
        {
            // Breaking Condition
            if (node == null)
            {
                return 0;
            }

            return SumOfBinaryTree(node.left) + node.value + SumOfBinaryTree(node.right);
        }
    }

    class Node
    {
        public int value;
        public Node left;
        public Node right;
    }
}
