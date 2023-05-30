using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    public class StackImplementationArray
    {
        public ArrayList arr;
        public StackImplementationArray()
        {
             arr= new ArrayList();
        }

        public void Peek()
        {
            if (this.arr.Count > 0)
            {
                Console.WriteLine(arr[arr.Count-1]);
                return;
            }
            Console.WriteLine("No Element available");
        }

        public void Push(string value)
        {
            arr.Add(value);
        }
        public void Pop()
        {
            if(arr.Count > 0){arr.RemoveAt(arr.Count - 1);}
            else { Console.WriteLine("Empty- Nothing to POP"); }
        }

        public void printStack()
        {
            if (arr.Count == 0) { Console.WriteLine("List is Empty"); return; }
            foreach(var item in arr)
            {
                Console.WriteLine("   |");
                Console.WriteLine(item);
            }
        }
    }
}
