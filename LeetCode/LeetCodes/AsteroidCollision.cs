using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class AsteroidCollision
    {
        public void AsteroidCollisonFun(int[] ast)
        {
            Stack<int> stack = new Stack<int>();
            //foreach(int aa in ast)
            for(int aa=0;aa<ast.Length;aa++)
            {
                while(stack.Count > 0 && ast[aa] < 0 && stack.Peek()>0)
                {
                    int diff = ast[aa] + stack.Peek();
                    
                    if(diff<0)
                    {
                        stack.Pop();
                    }
                    else if(diff>0)
                    {
                        ast[aa] = 0;
                    }
                    else
                    {
                        ast[aa] = 0;
                        stack.Pop();
                    }
                }

                if (ast[aa] != 0)
                {
                    stack.Push(ast[aa]);
                }
            }
            stack.ToArray();

            foreach(int ii in stack)
            {
                Console.WriteLine(ii);
            }
        }
    }
}
