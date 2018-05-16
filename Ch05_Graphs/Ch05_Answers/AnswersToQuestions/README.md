5-1. For the following graphs G1 (left) and G2 (right): 
(see book for figure) 
(see book for figure)

(a) Report the order of the vertices encountered on a breadth-first search starting from vertex A. Break all ties by picking the vertices in alphabetical order (i.e., A before Z).

(b) Report the order of the vertices encountered on a depth-first search starting from vertex A. Break all ties by picking the vertices in alphabetical order (i.e., A before Z).



![alt text](../../Ch05_Pictures/5_AQ_01_01.PNG "Figure_01")

<details>
<summary>**ANSWER**</summary>
  <p>

  (a) BFS:

- Graph G1: A, B, D, I, C, E, G, J, F, H
- Graph G2: A, B, E, C, F, I, D, G, J, M, H, K, N, L, O, P


(b) DFS:

- Graph G1: A, B, C, E, D, G, H, F, J, I
- Graph G2: A, B, C, D, H, G, F, E, I, J, K, L, P, O, N, M

  </p>
</details>


---

5-2. Do a topological sort of the following graph G: 
(see book for figure)

![alt text](../../Ch05_Pictures/5_AQ_02_01.PNG "Figure_01")


<details>
<summary>**ANSWER**</summary>
  <p>

  [Answer Here](../../Ch05_Answers/AnswersToQuestions/AQ_02_TopologicalSort_01.cs)

  Summary

  A topological sort is where For every directed edge uv from vertex u to vertex v, u comes before v in the ordering.

  - TopSort can be done with a DFS algorithm where the last child that is found with no more children will be the first item in a stack and then recurses adding to the stack the last node which has not yet been visited till there are no more nodes to add. 
    - Create a TopSort method with a stack for the result and a hash set for visited nodes.
	- For each node in the graph
	  - If the node has not been visited then call the TopSortUtil method (the recursive method)
	    - First step of the recursive method is to add the current node in the visited list
		- For each child in the adjacent list of the current node
		  - If the child has not been visited recurse the TopSortUtil passing in the child
		- Insert the node into the stack (not the child - this should be outside the foreach loop)

  </p>
</details>


---


5-3. Prove by induction that there is a unique path between any pair of vertices in a tree.


<details>
<summary>**ANSWER**</summary>
  <p>

  A tree is an acyclic graph.
The simplest possible tree is one with 2 nodes *x*(root) and *y*. There is only one direction. 

Assuming there is a unique path between *x* and *y*, we add a new leaf *z* under *y*. *z* is only connection to its parent *y* so there is only one way from *z* to *x* that is *z*->*y*->*x*.

  </p>
</details>


---


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