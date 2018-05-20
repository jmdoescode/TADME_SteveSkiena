5-28. An articulation vertex of a graph G is a vertex whose deletion disconnects G. Let G be a graph with n vertices and m edges. Give a simple O(n+m) algorithm for finding a vertex of G that is not an articulation vertex---i.e., whose deletion does not disconnect G.

<details>
<summary>**ANSWER**</summary>
  <p>

  An articulation vertex 'v' is present if one of two conditions are true.

  1. v is a root of the tree and has at least 2 children.
  
  2. v is not a root of the tree and has a child vertex 'u' such that no vertex in subtree rooted with 'u' has a back edge to one of the ancestors. 

  Summary
  - First case: Maintain a parent[] array where parent[u] stores parent of vertex u. For every vertex count children. If current vertex 'u' is root and has more than 2 children then print it.
  - Second case: Maintain an array disc[] to store discovery time of vertices. For every node u, find out the earliest visited vertex (with minimum discovery time) that can be reached from subtree rooted with 'u' and maintain an additional array low[u] = min(disc[u]. disc[w]) where w is an ancestor of u and there is a back edge from some descendant of u to w. 

  </p>
</details>