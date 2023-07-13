using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodes
{
    public class CourseSchedule
    {
        //------- DFS -----------------    
        public bool CanFinish(int numCourses, int[][] prerequisites)
            {
                // Create adjacency list to represent the graph
                List<List<int>> adjacencyList = new List<List<int>>();
                for (int i = 0; i < numCourses; i++)
                {
                    adjacencyList.Add(new List<int>());
                }

            

                // Build the adjacency list
                foreach (int[] prerequisite in prerequisites)
                {
                    int course = prerequisite[0];
                    int prerequisiteCourse = prerequisite[1];

                    adjacencyList[prerequisiteCourse].Add(course);
                }

            

            // Create an array to track the visited status of each course
            bool[] visited = new bool[numCourses];

                // Create an array to track the visiting status of each course during DFS
                bool[] visiting = new bool[numCourses];

                // Perform DFS for each course
                for (int course = 0; course < numCourses; course++)
                {
                    if (!visited[course] && !DFS(adjacencyList, course, visited, visiting))
                    {
                        return false; // A cycle is found
                    }
                }

                return true;
            }


            static bool DFS(List<List<int>> adjacencyList, int course, bool[] visited, bool[] visiting)
            {
                visiting[course] = true;

                foreach (int nextCourse in adjacencyList[course])
                {
                    if (visited[nextCourse]) // If already visited, skip
                        continue;

                    if (visiting[nextCourse]) // If already visiting, a cycle is found
                        return false;

                    if (!DFS(adjacencyList, nextCourse, visited, visiting))
                        return false;
                }

                visited[course] = true;
                visiting[course] = false;
                return true;
            }
        
    }
}
