using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class BreadthFirstSearch
    {
       public List<int> BreadthFirstSearchIterative(Node currentNode)
        {
            List<int> list = new List<int>();
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(currentNode);

            while(queue.Count > 0)
            {
                currentNode= queue.Dequeue();
                list.Add(currentNode.Value);
                if(currentNode.left!= null)
                {
                    queue.Enqueue(currentNode.left);
                }
                if(currentNode.right!=null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
            return list;
        } 


        public List<int> BreadthFirstSearchRecursive(Queue<Node> queue, List<int> list)
        {
            if (queue.Count == 0)
            {
                return list;
            }

            var currentNode= queue.Dequeue();
            list.Add(currentNode.Value);

            if(currentNode.left!= null)
            {
                queue.Enqueue(currentNode.left);
            }
            if(currentNode.right!= null)
            {
                queue.Enqueue(currentNode.right);
            }
            return BreadthFirstSearchRecursive(queue, list);
        }
        
    }
}
