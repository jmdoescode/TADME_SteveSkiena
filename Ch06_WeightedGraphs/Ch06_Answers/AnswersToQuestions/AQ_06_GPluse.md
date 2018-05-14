6-6. Suppose we are given the minimum spanning tree T of a given graph G (with n vertices and m edges) and a new edge e=(u,v) of weight w that we will add to G. Give an efficient algorithm to find the minimum spanning tree of the graph G+e. Your algorithm should run in O(n) time to receive full credit.


<details>
  <summary>**ANSWER**</summary>
  <p>
  
  Adding an edge to an already existing vertices in the graph is simple. You only have to decided whether the new edge has a weight less than the edge connected to the vertex u or vertex v. Then if it is smaller than both, pick the greatest to replace it. If it is smaller than only one of them then replace that one. 
  
</p>
</details>

