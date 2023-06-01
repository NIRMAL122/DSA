using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class Node
    {
        public int value { get; set;}
        public Node left { get; set;}
        public Node right { get; set;}
        public Node(int _value)
        {
            this.value = _value;
            this.left = null;
            this.right = null;
        }
    }
    public class BinarySearchTree
    {
        public Node root;
        public BinarySearchTree()
        {
            root = null;
        }

        public void insert(int value)
        {
            Node newNode = new Node(value);
            if (root == null)
            {
                this.root= newNode;
                return;
            }

            Node currentNode= root;
            while (true)
            {
                if(currentNode.value>value)
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

        public bool lookUp(int value)
        {
            if (root == null)
            {
                return false;
            }
            Node currentNode= root;
            while (currentNode != null)
            {
                if (value < currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else if(value> currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else if (value == currentNode.value)
                {
                    return true;
                }
            }
            return false;
        }

        public void remove(int value)
        {
            if (root == null) { return; }
            Node remove = root;
            Node parent = null;

            while (remove.value != value)
            {
                parent = remove;
                if (value < remove.value)
                {
                    remove = remove.left;
                }
                else if (value > remove.value)
                {
                    remove = remove.right;
                }
            }
                Node replace = null;
                if (remove.right != null)
                {
                    replace = remove.right;
                    if (replace.left == null)
                    {
                        replace.left = remove.left;
                    }
                    else
                    {
                        Node replaceParent = remove;
                        while (replace.left != null)
                        {
                            replaceParent = replace;
                            replace = replace.left;
                        }
                        replaceParent.left = null;
                        replace.left = remove.left;
                        replace.right= remove.right;
                    }
                }
                else if(remove.left != null)
                {
                replace = remove.left;

                }

            if (parent == null)
            {
                root = replace;
            }
            else if (parent.left == remove)
            {
                parent.left = replace;
            }
            else
            {
                parent.right = replace;
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
            Console.Write(root.value + "\n");

            // Process left child  
            print2DUtil(root.left, space);
        }
    }
}
