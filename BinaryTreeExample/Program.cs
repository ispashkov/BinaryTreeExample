using System;
using System.Collections.Generic;

namespace BinaryTreeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary Search Tree\n");

            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Insert(75);
            binaryTree.Insert(57);
            binaryTree.Insert(90);
            binaryTree.Insert(32);
            binaryTree.Insert(7);
            binaryTree.Insert(44);
            binaryTree.Insert(60);
            binaryTree.Insert(86);
            binaryTree.Insert(93);
            binaryTree.Insert(99);
            binaryTree.Insert(100);

            Console.WriteLine("Print Tree");
            binaryTree.Print();

            Console.WriteLine("Print smaller and biggest");
            Console.WriteLine(binaryTree.Smallest());
            Console.WriteLine(binaryTree.Largest());

        }


        public static int getHeight(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            return Math.Max(getHeight(root.LeftNode), getHeight(root.RightNode)) + 1;
        }

        public static bool isBalanced(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }

            int heightDiff = getHeight(root.LeftNode) - getHeight(root.RightNode);
            if (Math.Abs(heightDiff) > 1)
            {
                return false;
            }
            else
            {
                return (isBalanced(root.LeftNode) && isBalanced(root.RightNode));
            }
        }

    }
}
