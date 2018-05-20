using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch05
{
    using D1 = ADS_01_Graph;
    using A1 = AAL_01_DepthFirstSearch<int>;
    using A2 = AAL_02_BreadthFirstSearch<int>;

    [TestClass]
    public class UT_Algorithms
    {
        D1.Graph<int> gr_int = new D1.Graph<int>();


        /// <summary>
        /// All paths should be valid
        /// Will test different graphs for valid paths using DFS algorithm
        /// </summary>
        [TestMethod]
        public void Ch05_AL01_DFS_01_ReturnValidPath()
        {
            // Undirected graph with int nodes
            D1.AutoCreateGraph_01_Undirected_int(gr_int);            
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 5), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 2), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 6, 3), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 8, 2), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 7, 4), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 7, 5), true);

            // Directed graph with int nodes
            D1.AutoCreateGraph_02_Directed_int(gr_int);            
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 5), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 2), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 6, 3), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 8, 2), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 7, 4), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 7, 5), true);
        }


        /// <summary>
        /// All these paths should be invalid
        /// Will test different graphs for invalid paths using DFS algorithm
        /// </summary>
        [TestMethod]
        public void Ch05_AL01_DFS_02_ReturnInvalidPath()
        {
            // Undirected graph with int nodes
            D1.AutoCreateGraph_01_Undirected_int(gr_int);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 100), false);

            // Directed graph with int nodes
            D1.AutoCreateGraph_02_Directed_int(gr_int);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 2, 8), false);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 4, 8), false);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 5, 7), false);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 3, 1), false);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 3, 5), false);

            // Graph with no nodes
            D1.AutoCreateGraph_05_NoNodes_int(gr_int);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 2, 8), false);

            // Graph with 1 node
            D1.AutoCreateGraph_06_1Node_int(gr_int);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 2), false);

            // Graph with 2 nodes
            D1.AutoCreateGraph_07_2Nodes_int(gr_int);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 2), false);

            // Graph with 1 node disconnected
            D1.AutoCreateGraph_08_Directed_1UnconnectedNode_int(gr_int);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 2), false);

        }

        /// <summary>
        /// All paths should be valid
        /// Will test different graphs for valid paths using BFS algorithm
        /// </summary>
        [TestMethod]
        public void Ch05_AL01_BFS_01_ReturnValidPath()
        {
            // Undirected graph with int nodes
            D1.AutoCreateGraph_01_Undirected_int(gr_int);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 5), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 2), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 6, 3), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 8, 2), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 7, 4), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 7, 5), true);

            // Directed graph with int nodes
            D1.AutoCreateGraph_02_Directed_int(gr_int);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 5), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 2), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 6, 3), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 8, 2), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 7, 4), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 7, 5), true);
        }


        /// <summary>
        /// All these paths should be invalid
        /// Will test different graphs for invalid paths using BFS algorithm
        /// </summary>
        [TestMethod]
        public void Ch05_AL01_BFS_02_ReturnInvalidPath()
        {
            // Undirected graph with int nodes
            D1.AutoCreateGraph_01_Undirected_int(gr_int);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 100), false);

            // Directed graph with int nodes
            D1.AutoCreateGraph_02_Directed_int(gr_int);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 2, 8), false);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 4, 8), false);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 5, 7), false);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 3, 1), false);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 3, 5), false);

            // Graph with no nodes
            D1.AutoCreateGraph_05_NoNodes_int(gr_int);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 2, 8), false);

            // Graph with 1 node
            D1.AutoCreateGraph_06_1Node_int(gr_int);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 2), false);

            // Graph with 2 nodes
            D1.AutoCreateGraph_07_2Nodes_int(gr_int);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 2), false);

            // Graph with 1 node disconnected
            D1.AutoCreateGraph_08_Directed_1UnconnectedNode_int(gr_int);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 2), false);

        }
    }

}
