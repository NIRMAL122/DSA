using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class FindEventualSafeStates
    {
        public IList<int> EventualSafeNodes(int[][] graph)
        {
            var queue = new Queue<int>();
            var dict = new Dictionary<int, HashSet<int>>();
            var res = new List<int>();
            var degree = new int[graph.Length];

            //Console.WriteLine(graph.Length);

            for (var i = 0; i < graph.Length; i++)
            {
                foreach (var g in graph[i])
                {
                    if (!dict.ContainsKey(g))
                        dict.Add(g, new HashSet<int>());
                    dict[g].Add(i);
                }
                degree[i] += graph[i].Length;
                if (degree[i] == 0)
                    queue.Enqueue(i);
            }

            while (queue.Count > 0)
            {
                var cur = queue.Dequeue();
                res.Add(cur);
                if (!dict.ContainsKey(cur)) continue;
                foreach (var item in dict[cur])
                {
                    degree[item]--;
                    if (degree[item] == 0)
                        queue.Enqueue(item);
                }
            }
            res.Sort();
            return res;
        }
    }
}
