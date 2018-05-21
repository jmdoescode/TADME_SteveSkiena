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


---

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

---

5-6. In breadth-first and depth-first search, an undiscovered node is marked discovered when it is first encountered, and marked processed when it has been completely searched. At any given moment, several nodes might be simultaneously in the discovered state. 

(a) Describe a graph on n vertices and a particular starting vertex v such that Θ(n) nodes are simultaneously in the discovered state during a breadth-first search starting from v. 

(b) Describe a graph on n vertices and a particular starting vertex v such that Θ(n) nodes are simultaneously in the discovered state during a depth-first search starting from v. 

(c) Describe a graph on n vertices and a particular starting vertex v such that at some point Θ(n) nodes remain undiscovered, while Θ(n) nodes have been processed during a depth-first search starting from v. (Note, there may also be discovered nodes.)


<details>
<summary>**ANSWER**</summary>
  <p>

(a) A graph with root v and depth 1 (all n nodes are directly accessible from the root v).

(b) A graph with root v and a linear chain of n nodes.

(c) A graph with root v and two equal linear branches of lengths n/2.

  </p>
</details>

---

5-7. Given pre-order and in-order traversals of a binary tree, is it possible to reconstruct the tree? If so, sketch an algorithm to do it. If not, give a counterexample. Repeat the problem if you are given the pre-order and post-order traversals.

<details>
<summary>**ANSWER**</summary>
  <p>

  
**A.**

 Given the tree below:
 

           A
         /   \
        B     C
       / \   /
      D   E F


The preorder traversal is ABDECF and the inorder traversal is DBEAFC.

The recursive algorithm for re-constructing the tree is given thus:

1. Use the *preorder* traversal to find the tree root (which would be the first element i.e. *A*).

2. Use the *in-order* traversal to find the left sub tree (which corresponds to all elements before the tree root identified above).  
    - Repeat from step 1 if the node is not a leaf node

3. Use the *in-order* traversal to find the right sub tree (which corresponds to all elements after the tree root identified above).
    - Repeat from step 1 if the node is not a leaf node
 
**B.**

This is not possible.

**Note**: The tree can also be reconstructed if the *inorder* and *postorder* traversals are given.

  </p>
</details>

---

5-8. Present correct and efficient algorithms to convert an undirected graph G between the following graph data structures. You must give the time complexity of each algorithm, assuming n vertices and m edges.

(a) Convert from an adjacency matrix to adjacency lists.

(b) Convert from an adjacency list to an incidence matrix. 
  - An incidence matrix M has a row for each vertex and a column for each edge,
  - such that M[i,j]=1 if vertex i is part of edge j, otherwise M[i,j]=0.

(c) Convert from an incidence matrix to adjacency lists.

<details>
<summary>**ANSWER**</summary>
  <p>

  [Answer Here](../../Ch05_Answers/AnswersToQuestions/AQ_08_ConvertBetweenDataStructures.cs)

  </p>
</details>

---

5-9. Suppose an arithmetic expression is given as a tree. Each leaf is an integer and each internal node is one of the standard arithmetical operations (+,−,∗,/). For example, the expression 2+3∗4+(3∗4)/5 is represented by the tree in Figure (see book)(a). 

(see book for figure) 

(see book for figure) Give an O(n) algorithm for evaluating such an expression, where there are n nodes in the tree.


<details>
<summary>**ANSWER**</summary>
  <p>

  You can solve this problem by doing a DFS on the graph. Each node can be an operation or a literal. Literal will be leaves in the graph and operations will always have in this case both children. The recursive function "evaluates" the expression represented by each child node and then calculates the final result by applying the operation represented by the current node.

Here is an implementation in Java:

	class Main {

		public static void main(String[] args) {
			Node expression = new Addition(new Addition(new Literal(1), new Literal(2)),
					new Literal(3));
			System.out.println(expression.evaluate());
		}

		static interface Node {
			int evaluate();
		}

		static class Literal implements Node {
			int val;

			Literal(int val) {
				this.val = val;
			}

			@Override
			public int evaluate() {
				return val;
			}
		}

		static abstract class Op implements Node {
			Node operand1;
			Node operand2;

			Op(Node operand1, Node operand2) {
				this.operand1 = operand1;
				this.operand2 = operand2;
			}
		}

		static class Addition extends Op {
			Addition(Node operand1, Node operand2) {
				super(operand1, operand2);
			}

			@Override
			public int evaluate() {
				return operand1.evaluate() + operand2.evaluate();
			}
		}

		static class Substraction extends Op {
			Substraction(Node operand1, Node operand2) {
				super(operand1, operand2);
			}

			@Override
			public int evaluate() {
				return operand1.evaluate() - operand2.evaluate();
			}
		}

		static class Division extends Op {
			Division(Node operand1, Node operand2) {
				super(operand1, operand2);
			}

			@Override
			public int evaluate() {
				return operand1.evaluate() / operand2.evaluate();
			}
		}

		static class Multiplication extends Op {
			Multiplication(Node operand1, Node operand2) {
				super(operand1, operand2);
			}

			@Override
			public int evaluate() {
				return operand1.evaluate() / operand2.evaluate();
			}
		}

	}


  </p>
</details>



---

5-10 Suppose an arithmetic expression is given as a DAG (directed acyclic graph) with common subexpressions removed. Each leaf is an integer and each internal
node is one of the standard arithmetical operations (+,−, ∗, /). For example, the expression 2 + 3 ∗ 4 + (3 ∗ 4)/5 is represented by the DAG in Figure 5.17(b). Give an O(n + m) algorithm for evaluating such a DAG, where there are n nodes and m edges in the DAG. Hint: modify an algorithm for the tree case to achieve the desired efficiency.

<details>
<summary>**ANSWER**</summary>
  <p>
  
  [Answer Here](../../Ch05_Answers/AnswersToQuestions/AQ_10_EvaluateDAG.cs)

  Summary

  You will use recursion and go all the way down the left and then the right replacing the node with an operator with the correct arithmetic value of the left and right node based on the operator. 

  - Create a method that will receieve a Tree Node
  - If the node is a numeral, convert it to a numeric and return that value
  - as long as there is a value in the left node, recurse
  - as long as there is a value in the right node recurse
  - if the left and right value are not null
	- case statement - depending on the operator value of the node
		- do the correct arithmetic
	- set the value of the current node to the correct arithmetic value based on the operator in the case statement
  - return the node value


  </p>
</details>

---

5-11. The war story of Section 5.4 (page 158) describes an algorithm for constructing
            the dual graph of the triangulation efficiently, although it does not guarantee linear
            time. Give a worst-case linear algorithm for the problem.

    Consider the representation of data, the same way as in the war story.
    i.e a number vertices, and Triangles mentioned as a set of 3 vertices.

<details>
<summary>**ANSWER**</summary>
  <p>
  
  [Answer Here](../../Ch05_Answers/AnswersToQuestions/AQ_11_WarStoryGraphGet.cs)

  We will keep one adjacency Matrix. This matrix will tell whether or not an edge exists. If an edge exists, the matrix contains the pointer to the element representing the edge. Initially the Matrix is empty and have no idea about the edges. We will maintain an array of edges. Every element of this array will basically point to a list of triangles, that contain that edge. (This is similar to an adjacency list, where every vertex maintains a list of adjacent vertices). 
  
  For example:
 
 e1 -> T4   (Edge 1 is contained in Triangle 4)
 
 e2 -> T3   (Edge 2 is contained in Triangle 3)..

Now when we read a triangle, for every edge we check if that edge element is present in the Matrix. If so, the Matrix contains the pointer to the edge element. This edge element can be present in only 1 other Triangle. So we immediately get The triangle sharing the edge. This way we can get all adjacent Triangles (Max 3, one for each edge) for every triangle in constant time. For n triangles, this gives O(n) running time.

  </p>
</details>

---

5-12. The square of a directed graph G=(V,E) is the graph G2=(V,E2) such that (u,w)∈E2 iff there exists v∈V such that (u,v)∈E and (v,w)∈E; i.e., there is a path of exactly two edges from u to w. square of a graph Give efficient algorithms for both adjacency lists and matrices. 

<details>
<summary>**ANSWER**</summary>
  <p>

  To compute ***G<sup>2</sup>***

**Adjacency list**

    for each vertex in the adjacency list of node u
        for each vertex in the adjacency list of node v
            edge(u,w) exists in G2 iff edge(u,v) and edge(v,w) exist in G
                if so, add vertex w to the adjacency list of edge u 

This should be possible in time *(O(VE)*.

**Adjacency matrix**

The adjacency matrix of graph *G<sup>2</sup>* is the graph obtained by squaring the adjacency matrix of graph *G*.
This is possible in time *O(V<sup>3</sup>)*. 

  </p>
</details>


---

5-13. A vertex cover of a graph G=(V,E) is a subset of vertices V′ such that each edge in E is incident on at least one vertex of V′.

(a) Give an efficient algorithm to find a minimum-size vertex cover if G is a tree.

(b) Let G=(V,E) be a tree such that the weight of each vertex is equal to the degree of that vertex. Give an efficient algorithm to find a minimum-weight vertex cover of G.

(c) Let G=(V,E) be a tree with arbitrary weights associated with the vertices. Give an efficient algorithm to find a minimum-weight vertex cover of G.

Sources: 
	https://en.wikipedia.org/wiki/Vertex_cover
	
<details>
<summary>**ANSWER**</summary>
  <p>
  
(a) The problem of finding a minimum vertex cover is a classical optimization problem in computer science and is a typical example of an NP-hard optimization problem that has an approximation algorithm.

- Endpoints and parents will not be needed.
- Also if a node shares children or if a child of a node is another node's parent then that is not needed as well.

An effecient algorithm for this would be (for a tree):

- You can do this as a BFS.
- Start at the root.
- While the current node has children and it is not a leaf node, iteratedown.
- Add node to Minimum Vertex List. 
- Change current node to child node.
- Repeat while loop.

(b) A leaf is each 1 degree. This means that the parent's weight is the number of children + 1. We thus remove the parent and include the leaves. Then repeat.

(c) We know we will be able to remove at most one every other node, so we use a two-coloring technique (Red/Black) and perform a post-order traversal. Let's assume we will remove all the Black node. When we process a node, we also store with each node the sum over its immediate children of the respective Red and Black weight for the subtree. If not all of the children are Red, we need to mark the current node as Red. But we also have the option to reverse the coloring of all the Red-children's subtree. So we look at the sum over the red-children for Red and Black, and compare the difference of these sum to the current node's weight. If the current node's weight is above, we swap the coloring for these subtree. The current node will record the Black and Red sum of its children's subtree, and add its own weight to its color. 

  </p>
</details>


---

5-14. A vertex cover of a graph G=(V,E) is a subset of vertices V′∈V such that every edge in E contains at least one vertex from V′. Delete all the leaves from any depth-first search tree of G. Must the remaining vertices form a vertex cover of G? Give a proof or a counterexample. 

<details>
<summary>**ANSWER**</summary>
  <p>

  
Yes. All leafs should be unmarked while their parents are marked. 

  </p>
</details>


---

5-15. A vertex cover of a graph G=(V,E) is a subset of vertices V′∈V such that every edge in E contains at least one vertex from V′. An independent set of graph G=(V,E) is a subset of vertices V′∈V such that no edge in E contains both vertices from V′. An independent vertex cover is a subset of vertices that is both an independent set and a vertex cover of G. Give an efficient algorithm for testing whether G contains an independent vertex cover. What classical graph problem does this reduce to? 


<details>
<summary>**ANSWER**</summary>
  <p>



  </p>
</details>



---

5-16. An independent set of an undirected graph G=(V,E) is a set of vertices $U $ such that no edge in E is incident on two vertices of U.

Give an efficient algorithm to find a maximum-size independent set if G is a tree.

Let G=(V,E) be a tree with weights associated with the vertices such that the weight of each vertex is equal to the degree of that vertex. Give an efficient algorithm to find a maximum independent set of G.

Let G=(V,E) be a tree with arbitrary weights associated with the vertices. Give an efficient algorithm to find a maximum independent set of G.

<details>
<summary>**ANSWER**</summary>
  <p>
    
This translates to the question of labeling the tree with two colors, because this way each edge's vertices are colored differently. The larger group of colors is the sought for maximum-size independent set.

  </p>
</details>



---

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



---

5-18. Consider a set of movies $M_1, M_2, \ldots, M_k$. There is a set of customers, each one of which indicates the two movies they would like to see this weekend. Movies are shown on Saturday evening and Sunday evening. Multiple movies may be screened at the same time. You must decide which movies should be televised on Saturday and which on Sunday, so that every customer gets to see the two movies they desire. Is there a schedule where each movie is shown at most once? Design an efficient algorithm to find such a schedule if one exists.

Sources: https://en.wikipedia.org/wiki/Bipartite_graph


<details>
<summary>**ANSWER**</summary>
  <p>

  We have a set of Movies {M1, M2...Mk} and a set of Customers {C1, C2...Cp}. 

Each movie would be a node and for each customer would be an for the two movies they want to see. You are looking for a bipartite graph

  </p>
</details>



---

5-19. The diameter of a tree T=(V,E) is given by max u,v∈Vδ(u,v) (where δ(u,v) is the number of edges on the path from u to v). Describe an efficient algorithm to compute the diameter of a tree, and show the correctness and analyze the running time of your algorithm.

The diameter of a tree (sometimes called the width) is the number of nodes on the longest path between two end nodes.


<details>
<summary>**ANSWER**</summary>
  <p>

  Summary

- Start at the root node.
- Pass in root node and a reference int answer to the function.
- Get the height of the left using recursion by passing in the left node of the root node.
- Get the height of the right using recursion by passing in the right node of the root node.
- Update the answer which is equal to the max of the answer vs (1 + left_height + right height)
- The function returns 1 + max(left_height + right_height)
- The int variable answer is the correct answer to the height of the tree. 

  </p>
</details>





---

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




---

5-21. Let v and w be two vertices in a directed graph G=(V,E). Design a linear-time algorithm to find the number of different shortest paths (not necessarily vertex disjoint) between v and w. Note: the edges in G are unweighted.


<details>
<summary>**ANSWER**</summary>
  <p>

Summary

- Do a BFS
- Once you find the shortest path, put it into a dictionary.
- Continue BFS to find other paths.
- If another path has the same shortest path value and is different than the one in the dictioanry, insert it into dictionary.
- Return the count of items in the dictionary.


*Answer from source*:https://stackoverflow.com/questions/15211611/number-of-shortest-paths-in-a-graph

- With each vertex x associate 2 values: "count" and "val." Where count is the number of shortest paths from source to x and val is the shortest distance from - source to x.
- Of course maintain a visited list.
- Apply usual BFS algorithm.


*Answer from source*: https://mathoverflow.net/questions/4678/number-of-shortest-paths-problem

For a DAG.

- Suppose you have some designated start vertex s from which you want to count shortest paths. Then, if D(v) denotes the distance from s to v and N(v) denotes the number of shortest paths from s to v, then these two quantities may be computed by a single pass through all the vertices of the DAG, in a topological ordering: if v=s then D(v)=0 and N(v)=1, else D(v) is the minimum of D(w)+lenghth(w,v) over edges from w to v and N(v) is the sum of N(w) over vertices w achieving that minimum value.


  </p>
</details>



---

5-22. Design a linear-time algorithm to eliminate each vertex v of degree 2 from a graph by replacing edges (u,v) and (v,w) by an edge (u,w). We also seek to eliminate multiple copies of edges by replacing them with a single edge. Note that removing multiple copies of an edge may create a new vertex of degree 2, which has to be removed, and that removing a vertex of degree 2 may create multiple edges, which also must be removed.


<details>
<summary>**ANSWER**</summary>
  <p>
    
*Answer from source*: https://stackoverflow.com/questions/16125096/eliminating-vertices-from-a-graph

  </p>
</details>




---

5-23. Your job is to arrange n ill-behaved children in a straight line, facing front. You are given a list of m statements of the form i hates j. If i hates j, then you do not want put i somewhere behind j, because then i is capable of throwing something at j.

(a) Give an algorithm that orders the line, (or says that it is not possible) in O(m+n) time.

(b) Suppose instead you want to arrange the children in rows such that if i hates j, then i must be in a lower numbered row than j. Give an efficient algorithm to find the minimum number of rows needed, if it is possible.

<details>
<summary>**ANSWER**</summary>
  <p>

(a) Create a directed graph with the vertices representing the children and the edges representing the "i hates j" relations and use topological sorting. This will either give out a list representing the order in the line or tell you if it's not possible, i.e. a cycle is in the graph.

(b) Build a BFS graph from the directecd graph as built in the previous task. The maximum depth of this graph is the number of rows necessary.

  </p>
</details>

---

5-24. Adding a single directed edge to a directed graph can reduce the number of weakly connected components, but by at most how many components? What about the number of strongly connected components?


[Source](https://en.wikipedia.org/wiki/Strongly_connected_component): 
In the mathematical theory of directed graphs, a graph is said to be strongly connected or diconnected if every vertex is reachable from every other vertex. 


[Source](https://www.quora.com/What-are-strongly-and-weakly-connected-components): 
A weakly connected component is one in which all components are connected by some path, ignoring direction.


<details>
<summary>**ANSWER**</summary>
  <p>

  It can at most decrease the number of weakly connected components by 1. 

  It can decrease the number of strongly connected components by 0 to number of components - 1. This is because if you have a directed graph 1 -> 2 -> 3 -> 4 and created an edge from 4 -> 1 you would result in 1 strongly connected component where you had 3 before. 

  </p>
</details>

---

5-25. An arborescence of a directed graph G is a rooted tree such that there is a directed path from the root to every other vertex in the graph. Give an efficient and correct algorithm to test whether G contains an arborescence, and its time complexity.


<details>
<summary>**ANSWER**</summary>
  <p>

  Use [Edmond's algorithm](https://en.wikipedia.org/wiki/Edmonds'_algorithm).

  </p>
</details>

---

5-26. A mother vertex in a directed graph G=(V,E) is a vertex v such that all other vertices G can be reached by a directed path from v.

(a) Give an O(n+m) algorithm to test whether a given vertex v is a mother of G, where n=|V| and m=|E|.

(b) Give an O(n+m) algorithm to test whether graph G contains a mother vertex.


<details>
<summary>**ANSWER**</summary>
  <p>

  (a) Summary
  - Start at vertex v
  - You will need a Dictionary where the vertex is the key and true/false is the value. 
	- Initialize dictionary with all vertices and set all to false except v.
  - Do a BFS from v where you can only add nodes to the queue if they are reachable from the nodes in your queue. 
    - Start from source (v) to destination. For each destination vertex you visit change the dictionary value to true.
    - Destination changes to source. Repeat previous step.
  - At the end of BFS iterate through dictionary to see if any values are false.
    - If any values are false then v is not a mother.
  - Should take O(3(n) + m) which boils down to O(n + m).

  (b) Summary
  - Start at any vertex and do a BFS/DFS algorithm and keep a list of the last finished vertex.
  - If there exists a mother vertex then it must be in the list. Do a BFS/DFS to find if it is true (use the algorithm in step (a) for each vertex in the list).


  </p>
</details>

---

5-27. A tournament is a directed graph formed by taking the complete undirected graph and assigning arbitrary directions on the edges---i.e., a graph G=(V,E) such that for all u,v∈V, exactly one of (u,v) or (v,u) is in E. Show that every tournament has a Hamiltonian path---that is, a path that visits every vertex exactly once. Give an algorithm to find this path.


<details>
<summary>**ANSWER**</summary>
  <p>

  Proof by induction.

A tournament with 2 vertices (1,2) has a Hamiltonian path. 1 -> 2 or vice versa

Now suppose our tournament with n vertices has a Hamiltonian path 1,..,n. Now add a vertex (n+1) that is connected to every other node. 3 cases may occur:

case1) If the first node of the n Hamiltonian path can be reached by vertex (n+1), add (n+1) to the beginning of the path. New Hamiltonian path: n+1,1,...,n

case2) If the last node of the n Hamiltonian path can reach the vertex (n+1), add (n+1) to the end of the path. New Hamiltonian path: 1,...,n,n+1

case3) Take the first node of the n Hamiltonian path that can be reached by (n+1). This must exist, because we are not in case 2. Call this node k. By definition of this node, (k-1) can reach (n+1). Form the new Hamiltonian path as: 1,...,k-1,n+1,k,...,n.

  </p>
</details>

---

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

---

5-29. Following up on the previous problem, give an O(n+m) algorithm that finds a deletion order for the n vertices such that no deletion disconnects the graph. (Hint: think DFS/BFS.)

<details>
<summary>**ANSWER**</summary>
  <p>

  Summary:
  - Use logic from 5-28. Delete any vertex that is not in the output of 5-28. Run 5-28 algorithm again to refresh list and then repeat.

  </p>
</details>

---

5-30. Suppose G is a connected undirected graph. An edge e whose removal disconnects the graph is called a bridge. Must every bridge e be an edge in a depth-first search tree of G? Give a proof or a counterexample.

<details>
<summary>**ANSWER**</summary>
  <p>

  True. A DFS must visit all nodes in a connected graph. If the edge e is not in the connected graph then it will not be visited by DFS and could therefor not be a bridge that disconnects the graph. 

  </p>
</details>

---

5-31. Which data structures are used in depth-first and breath-first search?

<details>
<summary>**ANSWER**</summary>
  <p>

  DFS uses a stack (or if using recursion, recursion acts as a stack).

BFS uses a queue.

  </p>
</details>



---

5-32. Write a function to traverse binary search tree and return the ith node in sorted order.


<details>
<summary>**ANSWER**</summary>
  <p>
  
Use in order traversal until you find the ith node. 

  </p>
</details>

