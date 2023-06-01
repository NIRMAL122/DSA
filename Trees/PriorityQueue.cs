using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    public class PriorityQueue
    {
        public void PriorityQueueFun()
        {
            PriorityQueue<int,int> pq= new PriorityQueue<int,int>();
            //1 is max priority.
            // 10, 37, 18, 17, 8, 7 
            pq.Enqueue(7, 6);
            pq.Enqueue(10, 1);
            pq.Enqueue(17, 4);
            pq.Enqueue(18, 3);
            pq.Enqueue(8, 5);
            pq.Enqueue(37, 2);

            Console.WriteLine( pq.Peek());
            pq.Dequeue();
            Console.WriteLine(pq.Peek());

            //while(pq.Count> 0)
            //{
            //    int item = pq.Dequeue();
            //    Console.WriteLine(item);
            //}
        }
    }
}
