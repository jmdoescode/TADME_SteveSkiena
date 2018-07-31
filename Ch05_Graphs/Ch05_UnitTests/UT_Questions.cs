using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ch05
{
    using D1 = ADS_01_Graph;
    using Q02 = AQ_02_TopologicalSort_01<string>;

    [TestClass]
    public class UT_Questions
    {
        D1.Graph<string> g1 = new D1.Graph<string>();

        [TestMethod]
        public void Ch05_AQ_02_ReturnCorrectResult()
        {     
            //create graph
            D1.AutoCreateGraph_03_TopSort_Directed_for_AQ_02_string(g1);

            //Get result in a string no spaces
            List<Node<string>> resultList = Q02.TopSort(g1);
            StringBuilder sb = new StringBuilder();

            foreach(Node<string> node in resultList)
            {
                sb.Append(node.Id);
            }

            Assert.AreEqual(sb.ToString(), "ABDECFHGIJ");
        }
    }
}
