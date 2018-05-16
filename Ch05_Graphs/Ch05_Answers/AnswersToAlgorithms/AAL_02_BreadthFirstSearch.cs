using System;
using System.Collections.Generic;

/*  Breadth First Search (BFS) will go wide rather than deep
     *  For example say (a) has 3 children (b, c, d) and (b) has 1 child (e) and (e) has 1 child (f)
     *      And say you are looking for (f)
     *      BFS will look at all 3 children of (a) to see if they are (f) before moving forward
     *      Then it will go to the next level before going any deeper 
     *      
     *      while Depth First Search will ook at a, b, e, then f (not worrying about c, or d yet)
     *      
     *  It is iterative using a queue
     *  
     *  Usually better when finding the path
     * */

namespace Ch05
{
    using D = ADS_01_Graph;

    public class AAL_02_BreadthFirstSearch<T>
    {
        /// <summary>
        /// Finds out if a path exists from one node to another using Breadth First Search.
        /// Will check all the children of a node first before moving forward.
        /// </summary>
        /// <param name="graph">The graph that needs to be checked</param>
        /// <param name="source">The starting node.</param>
        /// <param name="destination">The result node.</param>
        /// <returns>Whether or not a path exitst from the source node to the destination node.</returns>
        public static bool HasPathBFS(D.Graph<T> graph, T source, T destination)
        {
            HashSet<D.Node<T>> visited = new HashSet<D.Node<T>>();          // Hash set of visited nodes
            Queue<D.Node<T>> notYetVisited = new Queue<D.Node<T>>();        // Queue of nodes to be visited
            D.Node<T> s = graph.GetNode(source);                            // Source node
            D.Node<T> d = graph.GetNode(destination);                       // Destination node

            // Enqueue node as the first node to be checked
            notYetVisited.Enqueue(s);

            // As long as there are nodes that have not yet been visited, iterate through the queue
            while(notYetVisited.Count > 0)
            {
                // Get 1 node from queue and add it to the hash set of visited nodes
                D.Node<T> current = notYetVisited.Dequeue();
                visited.Add(current);

                // You have reached the destination
                if (current == d) return true;

                // Insert the children of the node into the queue if they have not yet been visited
                foreach(D.Node<T> child in current.Adjacent)
                {
                    if(!visited.Contains(child))
                    {
                        notYetVisited.Enqueue(child);
                    }
                }
            }

            return false;
        }
    }
}
