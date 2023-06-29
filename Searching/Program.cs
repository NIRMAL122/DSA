namespace Searching
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Searching");

            BinarySearchTree bst= new BinarySearchTree();
            bst.Insert(9);
            bst.Insert(4);
            bst.Insert(20);
            bst.Insert(1);
            bst.Insert(6);
            bst.Insert(15);
            bst.Insert(170);

            bst.printTree(bst.root);

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            //Iterative Call
            //var result=bfs.BreadthFirstSearchIterative(bst.root);
            //foreach(int item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Recursive Call
            //Queue<Node> queue = new Queue<Node>();
            //queue.Enqueue(bst.root);
            //List<int> list= new List<int>();
            //var result = bfs.BreadthFirstSearchRecursive(queue, list);
            //foreach(int item in result)
            //{
            //    Console.WriteLine(item);
            //}
            

            DepthFirstSearch dfs = new DepthFirstSearch();
            Print(dfs.DFSInorder(bst.root), "InOrder");
            Print(dfs.DFSPreorder(bst.root), "PreOrder");
            Print(dfs.DFSPostorder(bst.root), "PostOrder");

            
            
        }

        private static void Print(List<int> list, string str)
        {
            Console.WriteLine();
            Console.Write(str+" -> ");
            foreach (var item in list)
            {
                Console.Write(item + "  ");
                //Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}