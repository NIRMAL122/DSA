using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class DepthFirstSearch
    {
        
        public List<int> DFSInorder(Node node)
        {
            List<int> result= new  List<int>();
            TraverseInOrder(node,result);
            return result;
        }
        public List<int> DFSPreorder(Node node)
        {
            List<int> result= new  List<int>();
            TraversePreOrder(node,result);
            return result;
        }
        public List<int> DFSPostorder(Node node)
        {
            List<int> result= new  List<int>();
            TraversePostOrder(node,result);
            return result;
        }

        public List<int> TraverseInOrder(Node node, List<int> list)
        {
            if(node.left!= null)
            {
                TraverseInOrder(node.left,list);
            }
            list.Add(node.Value);
            

            if(node.right!= null)
            {
                TraverseInOrder(node.right,list);
            }

            return list;

        }
        public List<int> TraversePreOrder(Node node, List<int> list)
        {
            list.Add(node.Value);

            if(node.left!= null)
            {
                TraversePreOrder(node.left,list);
            }
            

            if(node.right!= null)
            {
                TraversePreOrder(node.right,list);
            }

            return list;

        }
        public List<int> TraversePostOrder(Node node, List<int> list)
        {

            if (node.left!= null)
            {
                TraversePostOrder(node.left,list);
            }

            if (node.right!= null)
            {
                TraversePostOrder(node.right,list);
            }

            list.Add(node.Value);
            return list;

        }
    }
}
