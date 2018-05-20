using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    //==================================================================
    #region Algorithms

    using AL01 = AAL_01_DepthFirstSearch<int>;

    #endregion

    //==================================================================
    #region Data Structures

    using DS01 = ADS_01_Graph;
    using DS02 = ADS_02_AdjacencyMatrix;

    #endregion

    //==================================================================
    #region Questions

    using Q02 = AQ_02_TopologicalSort_01<string>;
    using Q08 = AQ_08_ConvertBetweenDataStructures<int>;
    using Q10 = AQ_10_EvaluateDAG;

    #endregion


    public class Program
    {
        static void Main(string[] args)
        {

            #region Algorithms

            Console.WriteLine("\n============================================================== AL_01_DepthFirstSeach");
            DS01.Graph<int> gAL01_01 = new DS01.Graph<int>();
            DS01.AutoCreateGraph_02_Directed_int(gAL01_01);
            AL01.PrintResult_AL_01_DepthFirstSearch(gAL01_01, 1, 5);


            Console.WriteLine("\n============================================================== AL_02_BreadthFirstSeach");
            DS01.Graph<int> gAL02_01 = new DS01.Graph<int>();
            DS01.AutoCreateGraph_02_Directed_int(gAL02_01);
            AL01.PrintResult_AL_01_DepthFirstSearch(gAL02_01, 1, 5);


            #endregion


            //=======================================================================================================================

            #region Questions

            Console.WriteLine("\n============================================================== Q_02 - 01 - Topological Sort");
            DS01.Graph<string> graphAQ02_01__1 = new DS01.Graph<string>();
            DS01.AutoCreateGraph_03_TopSort_Directed_for_AQ_02_string(graphAQ02_01__1); 
            graphAQ02_01__1.PrintGraph();
            Q02.PrintAllSort(graphAQ02_01__1);


            Console.WriteLine("\n==============================================================AQ_08 - 01 Convert from matrix to adjacency list\n");
            Q08 Q08 = new Q08();
            int[,] matrix = DS02.AutoCreateMatrix_01_Undirected();
            DS02.PrintMatrix(matrix);
            Q08.PrintAdjList(Q08.ConvertFrom_01_AdjMatrix_To_AdjList(matrix));


            Console.WriteLine("\n==============================================================AQ_10 - DAG Evaluation Algo\n");
            Q10 AQ10 = new Q10();
            AQ10.GetAnswer();
            

            #endregion
        }
    }
}
