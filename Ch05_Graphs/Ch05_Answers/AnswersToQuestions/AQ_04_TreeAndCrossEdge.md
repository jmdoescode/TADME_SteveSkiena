5-4. Prove that in a breadth-first search on a undirected graph G, every edge is either a tree edge or a cross edge, where x is neither an ancestor nor descendant of y, in cross edge (x,y).

* Cross edge being an edge that neither points to its descendants(forward edge) or points to its ancestors(backwards edge).
* Tree edge being an edge in which you visit a new node *v* that has not yet been discovered.


<details>
<summary>**ANSWER**</summary>
  <p>

  In a breadth-first search, when the algorithm is at depth *d*, it will look at all nodes at depth *d*+1. Assume an ancestor is detected that is not a tree edge. This implies the breadth-first search did not discover all child nodes at a previous level (i.e. at some depth level *k*, not all of the *k*+ 1 children were detected). This is a contradiction since the algorithm discovers all child nodes. Therefore every edge is either a tree edge or a cross edge.


Resources
* https://stackoverflow.com/questions/19937933/how-can-a-breadth-first-search-tree-include-a-cross-edge


  </p>
</details>