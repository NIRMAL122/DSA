using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searching
{
    public class Node
    {
        public int Value { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int _value)
        {
            this.Value = _value;
            this.left = null;
            this.right = null;
        }
    }
}
