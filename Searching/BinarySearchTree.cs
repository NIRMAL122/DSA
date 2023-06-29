using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void Insert(int value)
        {
            Node newNode = new Node(value);
            if (root == null)
            {
                root = newNode;
                return;
            }

            Node currentNode = root;
            while (true)
            {
                if (currentNode.Value > value)
                {
                    if (currentNode.left == null)
                    {
                        currentNode.left = newNode;
                        return;
                    }
                    currentNode = currentNode.left;
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        currentNode.right = newNode;
                        return;
                    }
                    currentNode = currentNode.right;
                }
            }
        }


        int COUNT = 5;
        public void printTree(Node node)
        {
            print2DUtil(root, 0);
        }

        private void print2DUtil(Node root, int space)
        {
            // Base case  
            if (root == null)
                return;

            // Increase distance between levels  
            space += COUNT;

            // Process right child first  
            print2DUtil(root.right, space);

            // Print current node after space  
            // count  
            Console.Write("\n");
            for (int i = COUNT; i < space; i++)
            {
                Console.Write(" ");
            }
            Console.Write(root.Value + "\n");

            // Process left child  
            print2DUtil(root.left, space);
        }
    }
}
