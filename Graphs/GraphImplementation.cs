using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    public class GraphImplementation
    {
        public Dictionary<int, List<int>> graph;
        public int numberOfNodes;

        public GraphImplementation() 
        {
            graph= new Dictionary<int, List<int>>();
            numberOfNodes=0;
        }

        public void addVertex(int value)
        {
            graph.Add(value, new List<int>());
            numberOfNodes++;
        }

        public void addEdge(int value1, int value2)
        {
            graph[value1].Add(value2);
            graph[value2].Add(value1);
        }

        public void print()
        {
            foreach(KeyValuePair<int, List<int>> pair in graph)
            {
                List<int> list = pair.Value;
                Console.Write(pair.Key+ "->" );
                foreach(int item in list)
                {
                    Console.Write(item+" ");
                }
                Console.WriteLine();
            }
        }

        
        public void showConnections()
        {
            foreach(var item  in graph)
            {
                List<int> nodeConnections = graph[item.Key];
                StringBuilder connections= new StringBuilder();
                foreach(var edge in nodeConnections)
                {
                    connections.Append(edge).Append(" ");
                }   
                Console.WriteLine(item.Key+ "->" + connections);
            }
        }
    }
}
