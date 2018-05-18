5-5. Give a linear algorithm to compute the chromatic number of graphs where each vertex has degree at most 2. Must such graphs be bipartite?

The chromatic number of a graph is the smallest number of colors needed to color the vertices of so that no two adjacent vertices share the same color.

* Bipartite definition 1 - graphs being a set of graph vertices decomposed into 2 disjoint sets such that no 2 graph vertices within the same set are adjacent. 
* Bipartite definition 2 - A graph whose vertices can be divided into 2 disjoint and independent sets *U* and *V* such that every edge connections a vertex in *U* to one in *V*
* Bipartite definition 3 - A graph is bipartite if it contains no cycles of odd length. 

Graphs with max degree 2, can be bipartite (even number of edges) or tripartite (odd number of edges)

Consider a triangle (3 edges, 3 vertices): it's not bipartite even though every node has an even number of edges and the graph has an even number of edges.

<details>
<summary>**ANSWER**</summary>
  <p>  
  
For such a graph, such that the degree of every vertex is at most 2, we can use a DFS traversal, coloring the child the opposite color of the parent. When we see a Back edge, we color the currently discovered child with a color different that the parent, and also different from the ancestor discovered through that back edge.

Since there is just one traversal, it runs in O(m + n) (m edges, n vertices)


**Another Solution:**

A graph whose each vertex has degree at most K has chromatic number less than equal to K + 1.

It is given that each degree has vertex at most 2, therefore determine whether the graph is two colourable or not with the help of BFS traversal. If it is then the answer is 2 otherwise the answer is 3. If graph has only one vertex then the answer will be 1.

  </p>
</details>