using System;
using System.Collections.Generic;
using System.Linq;

/*
 * 5-8. Present correct and efficient algorithms to convert an undirected graph G between the following graph data structures. You must give the time complexity of each algorithm, assuming n vertices and m edges.

(a) Convert from an adjacency matrix to adjacency lists.

(b) Convert from an adjacency list to an incidence matrix. 
  - An incidence matrix M has a row for each vertex and a column for each edge,
  - such that M[i,j]=1 if vertex i is part of edge j, otherwise M[i,j]=0.

(c) Convert from an incidence matrix to adjacency lists.
 * */



namespace Ch05
{

    public class AQ_08_ConvertBetweenDataStructures<T>
    {
        //===========================================================================================================================
        #region Printing

        public void PrintAdjList(Dictionary<T, Node<T>> list)
        {
            Console.Write("\n-------------------------------Adjacency List");
            foreach (KeyValuePair<T, Node<T>> kvp in list)
            {
                Console.Write($"\n[{kvp.Key.ToString()}]");
                foreach (Node<T> child in kvp.Value.Adjacent)
                {
                    Console.Write($"->{child.Id}");
                }
            }
            Console.WriteLine("\n");
        }

        #endregion

        //===========================================================================================================================
        #region Converts

        public Dictionary<int, Node<int>> ConvertFrom_01_AdjMatrix_To_AdjList(int[,] matrix)
        {
            Dictionary<int, Node<int>> nodes = new Dictionary<int, Node<int>>();

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    if (matrix[x, y] == 1)
                    {
                        Node<int> start = NodeHelper.GetOrAddNode<int>(x, nodes);
                        Node<int> end = NodeHelper.GetOrAddNode<int>(y, nodes);

                        start.AddNeighbor(end);
                    }
                }
            }

            return nodes;
        }

        //adjacency list to incidence matrix
        //https://en.wikipedia.org/wiki/Incidence_matrix
        //each edge has its own identity 

        /*  Need to create an Edges class
         *  It has a list of Nodes that are included in the edges
         *  Get all the edges
         *  Add it to a list
         *  the list index is the number of the column
         *  
         *  create int[x,y]
         *      where x is num of vertices
         *      where y is num of edges (listEdges.Count)
         *  
         *      if vertex is in the VertexList(listEdge[y].listOfVerices().Contains(vertex)) 
         *          of the Edge(listEdge[y])
         *          THEN 1
         *          ELSE 0
         * */


        // incidence matrix



        #endregion
    }
}
