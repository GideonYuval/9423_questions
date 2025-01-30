using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4.CollectionsLib;
using TreeDLR;
using System.Runtime.Remoting.Messaging;

namespace _9423
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

            //Q4
            son = BuildTree2();
            VisualTree<int>.DrawTree(son);
            IncreaseSon(son);
            VisualTree<int>.DrawTree(son);

            //Q5
            Console.WriteLine(SameValue(BuildTree5())); //T
            Console.WriteLine(SameValue(BuildTree1())); //F

            //Q6
            Console.WriteLine(CheckIsPrimeProduct(BuildTree6())); //T
            Console.WriteLine(IsPrimeProduct(BuildTree6(), 20)); //T


        }

        // Tree 1                        Tree 2                        Tree 3                        Tree 4
        //          1                            1                           -1                            m
        //       /     \                      /     \                      /     \                      /     \
        //      3       2                    2       3                   -2      3                     a       r
        //     /       / \                  / \     / \                 /  \    /  \                  / \     / \
        //    9       6   8                2   5   6   7              -4    3  6   -8                z   d   e   w
        //     \
        //      7

        // Tree 5
        //          4   
        //       /     \
        //      2       6
        //     / \     / \
        //    1   3   5   7

        // Tree 6
        //          20
        //         /  \
        //        2    10
        //            /  \
        //           2    5


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
            return false;
        }

        //Q4
        //parameters - tree of ints
        //return - void
        //change the tree - if a son's value is equal to his father, increase son's value by 1
        //use Tree2 to test

        static void IncreaseSon(BinNode<int> root)
        {

        }

        //Q5
        //parameters - tree of ints
        //return - True, if all fathers with 2 sons are equal to the average of the 2 sons
        //think - what should be returned for a null tree? why?
        static bool SameValue(BinNode<int> root)
        {
            return false;
        }


        //Q6
        //part 1:
        //parameters - tree of ints
        //return - True, only if
        //1. each node is either a leaf or a father of 2 nodes
        //2. each non-leaf node is equal to the product of its 2 sons (e.g. 21 = 3 * 7)
        //3. each leaf is prime
        //use: IsPrime
        //check with Tree6
        //part 2:
        //the function now also gets an int. need to check conditions 1-3 above, and:
        //4. root value = num
        //tip: write wrapper function
        //question - when are wrapper functions needed???




        static bool CheckIsPrimeProduct(BinNode<int> root)
        {
            return false;
        }

        //part 2
        static bool IsPrimeProduct(BinNode<int> root, int value)
        {
            return false;
        }

        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
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
            leftChild.SetLeft(new BinNode<int>(2));
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

        static BinNode<int> BuildTree5()
        {
            BinNode<int> root = new BinNode<int>(7);

            root.SetLeft(new BinNode<int>(7));
            root.SetRight(new BinNode<int>(7));

            root.GetLeft().SetLeft(new BinNode<int>(7));
            root.GetLeft().SetRight(new BinNode<int>(7));

            root.GetRight().SetLeft(new BinNode<int>(7));
            root.GetRight().SetRight(new BinNode<int>(7));

            return root;
        }

        static BinNode<int> BuildTree6()
        {
            BinNode<int> root = new BinNode<int>(20);

            BinNode<int> left = new BinNode<int>(2); // Prime leaf
            BinNode<int> right = new BinNode<int>(10);

            root.SetLeft(left);
            root.SetRight(right);

            BinNode<int> rightLeft = new BinNode<int>(2); // Prime leaf
            BinNode<int> rightRight = new BinNode<int>(5); // Prime leaf

            right.SetLeft(rightLeft);
            right.SetRight(rightRight);

            return root;
        }

    }
}
