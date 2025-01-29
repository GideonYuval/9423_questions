using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;
using TreeDLR;

namespace _9423_questions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //BinNode<string> tree = VisualTree<string>.GetTree();
            //Q1

            BinNode<int> son = BuildTree1();
            VisualTree<int>.DrawTree(son);
            AddSon(son);
            VisualTree<int>.DrawTree(son);

            //Q2
            son = BuildTree1();
            PrintOneSon(son);

            //Q3
            Console.WriteLine(IsAll2Children(BuildTree1()));
            Console.WriteLine(IsAll2Children(BuildTree2()));



        }

        // Tree 1                        Tree 2                        Tree 3                        Tree 4
        //          1                            1                           -1                            m
        //       /     \                      /     \                      /     \                      /     \
        //      3       2                    2       3                   -2      3                     a       r
        //     /       / \                  / \     / \                 /  \    /  \                  / \     / \
        //    9       6   8                4   5   6   7              -4    3  6   -8                z   d   e   w
        //     \
        //      7

        // Tree 5
        //          4   
        //       /     \
        //      2       6
        //     / \     / \
        //    1   3   5   7


        //Q1
        //parameter - tree of ints
        //return - nothing
        //to each node with only one child, add a second child with value 0
        static void AddSon(BinNode<int> root)
        {

        }



        //Q2
        //parameter - tree of ints
        //return - nothing
        //print values of all nodes which have only one child

        static void PrintOneSon(BinNode<int> root)
        {


        }

        //Q3
        //parameters - tree of ints
        //return - TRUE if ALL non-leaves have 2 children

        static bool IsAll2Children(BinNode<int> root)
        {
            return 0;
        }












        public static BinNode<int> BuildTree1()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(1);

            // Left subtree
            BinNode<int> node3 = new BinNode<int>(3);
            node3.SetLeft(new BinNode<int>(9));
            node3.GetLeft().SetRight(new BinNode<int>(7));

            // Right subtree
            BinNode<int> node2 = new BinNode<int>(2);
            node2.SetLeft(new BinNode<int>(6));
            node2.SetRight(new BinNode<int>(8)); // Hidden child set to 8

            // Attach left and right subtrees to root
            root.SetLeft(node3);
            root.SetRight(node2);

            return root;
        }

        // Tree structure:
        //          1
        //       /     \
        //      3       2
        //     /       / \
        //    9       6   8
        //     \
        //      7

        static BinNode<int> BuildTree2()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(1);

            // Left subtree
            BinNode<int> leftChild = new BinNode<int>(2);
            leftChild.SetLeft(new BinNode<int>(4));
            leftChild.SetRight(new BinNode<int>(5));

            // Right subtree
            BinNode<int> rightChild = new BinNode<int>(3);
            rightChild.SetLeft(new BinNode<int>(6));
            rightChild.SetRight(new BinNode<int>(7));

            // Attach subtrees to root
            root.SetLeft(leftChild);
            root.SetRight(rightChild);

            return root;
        }

        // Tree structure:
        //          1
        //       /     \
        //      2       3
        //     / \     / \
        //    4   5   6   7

        static BinNode<int> BuildTree3()
        {
            // Root node
            BinNode<int> root = new BinNode<int>(-1); // Root value is negative

            // Left subtree
            BinNode<int> leftChild = new BinNode<int>(-2); // Left child of root
            leftChild.SetLeft(new BinNode<int>(-4));       // Left child of node -2
            leftChild.SetRight(new BinNode<int>(3));       // Right child of node -2

            // Right subtree
            BinNode<int> rightChild = new BinNode<int>(3); // Right child of root
            rightChild.SetLeft(new BinNode<int>(6));       // Left child of node 3
            rightChild.SetRight(new BinNode<int>(-8));     // Right child of node 3 (negative)

            // Attach subtrees to root
            root.SetLeft(leftChild);
            root.SetRight(rightChild);

            return root;
        }

        // Tree structure:
        //         -1
        //       /    \
        //     -2      3
        //    /  \    /  \
        //  -4    5  6   -7

        static BinNode<char> BuildTree4()
        {
            // Root node
            BinNode<char> root = new BinNode<char>('m'); // Root value

            // Left subtree
            BinNode<char> leftChild = new BinNode<char>('a'); // Left child of root
            leftChild.SetLeft(new BinNode<char>('z'));       // Left child of node 'a'
            leftChild.SetRight(new BinNode<char>('d'));      // Right child of node 'a'

            // Right subtree
            BinNode<char> rightChild = new BinNode<char>('r'); // Right child of root
            rightChild.SetLeft(new BinNode<char>('e'));        // Left child of node 'r'
            rightChild.SetRight(new BinNode<char>('w'));       // Right child of node 'r'

            // Attach subtrees to root
            root.SetLeft(leftChild);
            root.SetRight(rightChild);

            return root;
        }
        // Tree structure:
        //          m
        //       /     \
        //      a       r
        //     / \     / \
        //    z   d   e   w



    }
}
