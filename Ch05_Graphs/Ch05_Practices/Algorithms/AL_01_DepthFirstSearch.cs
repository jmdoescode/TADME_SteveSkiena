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

namespace Ch05.Algorithms
{
    public class AL_01_DepthFirstSearch<T>
    {

        //======================================================================================
        //--------------------------------------------------------------------------------------
        // TODO: CODE Depth First Search HERE




        //--------------------------------------------------------------------------------------
        //======================================================================================		



        #region Given code - for debug only - uncomment when ready

        ///// <summary>
        ///// Prints the results of the HasPathDFS method 
        ///// </summary>
        ///// <param name="graph"></param>
        ///// <param name="source"></param>
        ///// <param name="destination"></param>
        //public static void PrintResult_AL_01_DepthFirstSearch(DS01.Graph<T> graph, T source, T destination)
        //{
        //    bool result = HasPathDFS(graph, source, destination);
        //    Console.Write("\n\n- AL_01 - Depth-First Search: ");
        //    Console.Write($"\n\n\t {result}");
        //    Console.WriteLine("\n\n");
        //}

        #endregion
    }
}
