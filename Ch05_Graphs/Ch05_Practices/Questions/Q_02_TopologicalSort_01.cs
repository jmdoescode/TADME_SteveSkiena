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

    public class Q_02_TopologicalSort_01<T>
    {

        //======================================================================================
        //--------------------------------------------------------------------------------------
        // TODO: CODE Topological Sort HERE




        //--------------------------------------------------------------------------------------
        //======================================================================================



        #region Given code - for debug only - uncomment when ready

        /*
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

        //*/

        #endregion
    }
}
