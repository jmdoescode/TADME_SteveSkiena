using System;
using System.Collections.Generic;

/*  5-2. Do a topological sort of the following graph G: 
        (see book for figure)

    For every directed edge uv from vertex u to vertex v, u comes before v in the ordering.
 * 
 * */

namespace Ch05
{
    using DS01 = Ch05.ADS_01_Graph;

    public class AQ_02_TopologicalSort_01<T>
    {
        /// <summary>
        /// Topologicaly sorts the graph that is passed in. 
        /// Uses a stack of resulting nodes and a hash set of visited nodes.
        /// A Depth-First Search is used to get the last node in the list to add to the stack. Which is the TopSortUtil method.
        /// </summary>
        /// <param name="graph">The graph that needs to be sorted</param>
        /// <returns>A topologically sorted list of nodes in the graph.</returns>
        public static List<DS01.Node<T>> TopSort(DS01.Graph<T> graph)
        {
            List<DS01.Node<T>> stack = new List<DS01.Node<T>>();                // Is a list but is used as a stack
            HashSet<DS01.Node<T>> visited = new HashSet<DS01.Node<T>>();        // Nodes that have already been visited

            // Iterates through all the nodes in the graph and calls TopSortUtil
            // TopSortUtil is a DFS algorithm that will add the last node as the first item in the stack
            foreach (DS01.Node<T> node in graph.GetAllNodes())
            {
                if (visited.Contains(node))
                {
                    continue;
                }
                TopSortUtil(node, stack, visited);
            }

            return stack;
        }


        /// <summary>
        /// Recurses until it hits the last node then inserts the node at the beginning of the stack.
        /// Will insert the last child first and move its way upwards. 
        /// Uses a Depth-First Search algorithm to get the nodes. 
        /// </summary>
        /// <param name="node">The node that needs to be sorted</param>
        /// <param name="stack">The list which acts a stack</param>
        /// <param name="visited">Hash set of visited nodes</param>
        private static void TopSortUtil(DS01.Node<T> node, List<DS01.Node<T>> stack, HashSet<DS01.Node<T>> visited)
        {
            // Node is not yet added to list so add it
            visited.Add(node);

            // Iterates through all the children of every node
            // If the visited list does not contain the node then recurse passing in new node
            // Will insert the very last element at the beginning of the list (hence a stack)
            // The very last element is the last node that has no more children
            foreach (DS01.Node<T> child in node.Adjacent)
            {
                if (!visited.Contains(child))
                {
                    TopSortUtil(child, stack, visited);
                }
            }
            stack.Insert(0, node);
        }


        /// <summary>
        /// Calls the top sort and then prints out the result
        /// </summary>
        /// <param name="graph">Graph that needs to be sorted</param>
        public static void PrintAllSort(DS01.Graph<T> graph)
        {
            List<DS01.Node<T>> result = TopSort(graph);
            Console.Write("\n\n- AQ_02_TopSort_01 - Topological Sort: ");
            Console.Write("\n\n\t");
            foreach (DS01.Node<T> node in result)
            {
                Console.Write($"->{node.Id.ToString()}");
            }
            Console.WriteLine("\n\n");
        }
    }
}
