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

        [TestMethod]
        public void Ch05_AL01_DFS_ReturnResults()
        {
            //Directed graph with int nodes
            D1.AutoCreateGraph_02_Directed_int(gr_int);

            //All these paths should be valid
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 5), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 1, 2), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 6, 3), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 8, 2), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 7, 4), true);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 7, 5), true);

            //All these paths should be invalid 
            Assert.AreEqual(A1.HasPathDFS(gr_int, 2, 8), false);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 4, 8), false);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 5, 7), false);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 3, 1), false);
            Assert.AreEqual(A1.HasPathDFS(gr_int, 3, 5), false);
        }

        [TestMethod]
        public void Ch05_AL02_BFS_ReturnResults()
        {
            //Directed graph with int nodes
            D1.AutoCreateGraph_02_Directed_int(gr_int);

            //All these paths should be valid
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 5), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 1, 2), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 6, 3), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 8, 2), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 7, 4), true);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 7, 5), true);

            //All these paths should be invalid 
            Assert.AreEqual(A2.HasPathBFS(gr_int, 2, 8), false);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 4, 8), false);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 5, 7), false);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 3, 1), false);
            Assert.AreEqual(A2.HasPathBFS(gr_int, 3, 5), false);
        }
    }
}
