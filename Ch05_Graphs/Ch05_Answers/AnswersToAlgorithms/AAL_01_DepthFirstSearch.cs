using System;
using System.Collections.Generic;


/*  Depth First Search (DFS) will go wide rather than deep
 *  For example say (a) has 3 children (b, c, d) and (b) has 1 child (e) and (e) has 1 child (f)
 *      And say you are looking for (f)
 *      DFS will look into at (a), (b), (e), then (f) - totally passing (c, d)
 *      
 *      while Breadth First Search will look at all children of a first then go to the next level
 *      
 *  This is more like a stack (although not explicitly using a stack because recursion will act as that stack)
 *  
 *  Will work for undirected and directed graphs
 * */

namespace Ch05
{
    using DS01 = ADS_01_Graph;

    public class AAL_01_DepthFirstSearch<T>
    {
        /// <summary>
        /// Parent method which calls the recursive HasPathDFSUtil method. 
        /// Finds out if there is a path to a node in a graph from a starting node using a Depth-First Search.
        /// </summary>
        /// <param name="graph">Graph for the DFS search</param>
        /// <param name="source">The starting point of the algorithm</param>
        /// <param name="destination">The node to be found</param>
        /// <returns>Whether or not a path exists to a destination node from a source node.</returns>
        public static bool HasPathDFS(DS01.Graph<T> graph, T source, T destination)
        {
            //base case if there is no destination node
            if (graph.GetNode(destination) == null) return false;

            HashSet<Node<T>> visited = new HashSet<Node<T>>();            
            return HasPathDFSUtil(graph.GetNode(source), graph.GetNode(destination), visited);
        }


        /// <summary>
        /// Recursive method that will go first to the first child of the node before going to any other children, hence Depth-First Search.
        /// </summary>
        /// <param name="source">The starting node</param>
        /// <param name="destination">The ending node</param>
        /// <param name="visited">Hash set of visited nodes</param>
        /// <returns>Whether or not the source is the destination or to put it simply whether or not a path exists to a node</returns>
        static bool HasPathDFSUtil(Node<T> source, Node<T> destination, HashSet<Node<T>> visited)
        {
            // If the visited hash set does not contain the node, then add it to the hash set otherwise return false for having already visited it
            if (visited.Contains(source) || source == null)
                return false;
            else
                visited.Add(source);

            // Return true if the source is the destination, meaning there is a path to the node
            if (source == destination) return true;

            // Iterate through the children of the source node
            // If the child has not been visited then recurse the method passing in the child to see if the child is the destination node and return true if it is
            foreach(Node<T> child in source.Adjacent)
            {
                if(!visited.Contains(child))
                {
                    if (HasPathDFSUtil(child, destination, visited)) return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Prints the results of the HasPathDFS method 
        /// </summary>
        /// <param name="graph"></param>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        public static void PrintResult_AL_01_DepthFirstSearch(DS01.Graph<T> graph, T source, T destination)
        {
            bool result = HasPathDFS(graph, source, destination);
            Console.Write("\n\n- AL_01 - Depth-First Search: ");
            Console.Write($"\n\n\t {result}");            
            Console.WriteLine("\n\n");
        }
    }
}
