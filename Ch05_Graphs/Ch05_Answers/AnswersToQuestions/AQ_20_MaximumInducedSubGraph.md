5-20. Given an undirected graph G with n vertices and m edges, and an integer k, give an O(m+n) algorithm that finds the maximum induced subgraph H of G such that each vertex in H has degree ≥k, or prove that no such graph exists. An induced subgraph F=(U,R) of a graph G=(V,E) is a subset of U of the vertices V of G, and all edges R of G such that both vertices of each edge are in U.


<details>
<summary>**ANSWER**</summary>
  <p>

Summary

- Do a DFS and for each vertex, keep a count of the number of edges of each vertex in a dictionary. 
- Increment count when you visit the vertex and increment count when you visit one of its neighbors. 
- Then you go through dictionary and for each vertex in the dictionary you insert into a hashset.
- Then you iterate the hashset and for each vertext you find if a neighbor in that vertex is also in the hashset.


*Answer via source*: https://stackoverflow.com/questions/10205191/graph-how-to-find-maximum-induced-subgraph-h-of-g-such-that-each-vertex-in-h-h

- This is a k-core problem. 
- Evaluate the degrees of all vertices O(m);
- Go through vertices with degree < k. When you find such a vertext delete it from the graph and update the degrees of the neighbors (also deleting neighbors  whose- degrees drop below k).
- You need to look at each vertex at least once O(n) and update degrees at most once for each edge O(m).
- The remaining connected components are k-cores. 
- Find the biggest one by evaluating their sizes.

  </p>
</details>


