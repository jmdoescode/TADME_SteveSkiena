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

    #endregion

    //==================================================================
    #region Questions

    using Q02 = AQ_02_TopologicalSort_01<string>;

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

            #endregion
        }
    }
}
