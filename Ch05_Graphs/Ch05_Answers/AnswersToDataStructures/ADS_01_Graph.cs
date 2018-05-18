using System;
using System.Collections.Generic;
using System.Linq;

namespace Ch05
{   
    public class ADS_01_Graph
    {
        public class Graph<T>
        {
            private Dictionary<T, Node<T>> nodeLookup = new Dictionary<T, Node<T>>();

            public Node<T> GetNode(T id)
            {
                if(nodeLookup.ContainsKey(id))
                {
                    return nodeLookup.Single(x => x.Key.ToString() == id.ToString()).Value;
                }
                else
                {
                    return null;
                }                
            }

            public void AddNode(T id)
            {
                if (!nodeLookup.ContainsKey(id))
                {
                    Node<T> s = new Node<T>(id);
                    nodeLookup.Add(id, s);                    
                }
            }

            public void AddEdge(T source, T destination)
            {
                AddNode(source);
                AddNode(destination);
                Node<T> s = GetNode(source);
                Node<T> d = GetNode(destination);

                s.Adjacent.AddLast(d);
                d.Adjacent.AddLast(s);
            }

            public void AddEdgeDirected(T source, T destination)
            {
                AddNode(source);
                AddNode(destination);
                Node<T> s = GetNode(source);
                Node<T> d = GetNode(destination);

                s.Adjacent.AddLast(d);
            }

            public void PrintGraph()
            {
                Console.WriteLine("\n\n------------------------------------- ADS_01 - Print Graph");
                foreach (KeyValuePair<T, Node<T>> kvp in nodeLookup)
                {
                    Node<T> val = kvp.Value;
                    Console.Write($"[{val.Id}]: ");
                    foreach (Node<T> adj in val.Adjacent)
                    {
                        Console.Write($"-> {adj.Id}");
                    }
                    Console.WriteLine();
                }
            }

            public List<Node<T>> GetAllNodes()
            {
                List<Node<T>> result = new List<Node<T>>();

                foreach (KeyValuePair<T, Node<T>> kvp in nodeLookup)
                {
                    result.Add(kvp.Value);
                }

                return result;
            }

            public void ClearGraph()
            {
                nodeLookup.Clear();
            }
        }

        #region Auto Create Graphs for testing purposes - pass in the graph

        public static void AutoCreateGraph_01_Undirected_int(Graph<int> g)
        {
            g.ClearGraph();

            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(1, 4);
            g.AddEdge(1, 6);
            g.AddEdge(2, 3);
            g.AddEdge(3, 6);
            g.AddEdge(4, 6);
            g.AddEdge(5, 6);
            g.AddEdge(6, 8);
            g.AddEdge(7, 8);
        }

        public static void AutoCreateGraph_02_Directed_int(Graph<int> g)
        {
            g.ClearGraph();

            g.AddEdgeDirected(1, 2);
            g.AddEdgeDirected(1, 3);
            g.AddEdgeDirected(1, 4);

            g.AddEdgeDirected(4, 6);

            g.AddEdgeDirected(6, 1);
            g.AddEdgeDirected(6, 3);

            g.AddEdgeDirected(2, 3);
            g.AddEdgeDirected(3, 2);

            g.AddEdgeDirected(5, 6);
            g.AddEdgeDirected(6, 5);

            g.AddEdgeDirected(8, 6);

            g.AddEdgeDirected(7, 8);
        }

        public static void AutoCreateGraph_03_TopSort_Directed_for_AQ_02_string(Graph<string> graph)
        {
            graph.ClearGraph();

            graph.AddEdgeDirected("A", "B");
            graph.AddEdgeDirected("B", "C");
            graph.AddEdgeDirected("C", "F");
            graph.AddEdgeDirected("F", "H");
            graph.AddEdgeDirected("H", "G");
            graph.AddEdgeDirected("G", "F");

            graph.AddEdgeDirected("G", "I");
            graph.AddEdgeDirected("I", "J");
            graph.AddEdgeDirected("H", "J");

            graph.AddEdgeDirected("B", "E");
            graph.AddEdgeDirected("E", "C");
            graph.AddEdgeDirected("E", "F");
            graph.AddEdgeDirected("E", "G");

            graph.AddEdgeDirected("B", "D");
            graph.AddEdgeDirected("D", "E");
            graph.AddEdgeDirected("D", "G");

            graph.AddEdgeDirected("A", "D");
        }

        public static void AutoCreateGraph_04_TopSort_Directed_string(Graph<string> graph)
        {
            graph.ClearGraph();

            graph.AddEdgeDirected("A", "C");
            graph.AddEdgeDirected("B", "C");
            graph.AddEdgeDirected("B", "D");
            graph.AddEdgeDirected("C", "E");
            graph.AddEdgeDirected("E", "F");
            graph.AddEdgeDirected("D", "F");
            graph.AddEdgeDirected("F", "G");
        }

        public static void AutoCreateGraph_05_NoNodes_int(Graph<int> graph)
        {
            graph.ClearGraph();
        }

        public static void AutoCreateGraph_06_1Node_int(Graph<int> graph)
        {
            graph.ClearGraph();

            graph.AddNode(1);
        }

        public static void AutoCreateGraph_07_2Nodes_int(Graph<int> graph)
        {
            graph.ClearGraph();

            graph.AddNode(1);
            graph.AddNode(2);
        }

        public static void AutoCreateGraph_08_Directed_1UnconnectedNode_int(Graph<int> graph)
        {
            graph.ClearGraph();

            graph.AddNode(1);
            graph.AddEdge(2, 3);
        }


        #endregion
    }
}
