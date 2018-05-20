5-17. Consider the problem of determining whether a given undirected graph G=(V,E) contains a triangle or cycle of length 3.

(a) Give an O(|V|3) to find a triangle if one exists.

(b) Improve your algorithm to run in time O(|V|⋅|E|). You may assume |V|≤|E|.

Observe that these bounds gives you time to convert between the adjacency matrix and adjacency list representations of G.


<details>
<summary>**ANSWER**</summary>
  <p>

  (a) Compare every possible set of three vertices and test if there is an edge between them.

(b) Edge Iterator algorithm. Iterates over all edges and compares the adjacency data structure of both incident nodes. For an edge {x, y} and the nodes {x, y, z} induce a triangle if and only if the node {z} is present in both adjacency data structures of {x} and {y}.


	Sources: http://i11www.iti.kit.edu/extra/publications/sw-fclt-05_t.pdf

  </p>
</details>
**ANSWERS**

