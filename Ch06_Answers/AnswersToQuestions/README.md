6-1. For the graphs in Problem (see book):

(a) Draw the spanning forest after every iteration of the main loop in Kruskal's algorithm. 

(b) Draw the spanning forest after every iteration of the main loop in Prim's algorithm.

(c) Find the shortest path spanning tree rooted in A.

(d) Compute the maximum flow from A to H.

A spanning forest being a forest that spans all of the vertices, meaning only that each vertex of the graph is a vertex in the forest. For this definition even a connected graph may have a disconnected spanning forest, such as the forest in which each vertex forms a single-vertex tree.

<details>
  <summary>**ANSWER**</summary>
  <p>

(a) Kruskal's algorithm uses a priority queue from lowest to highest value and then uses a union find data structure to find the minimal spanning tree. It goes through each edge and finds whether the component 1 already exists within a tree of component 2 and vice versa (this will prevent creation of cycles). If the components are not in the same tree then the algorithm will union the two components together. Once there are no more components to match and the algorithm has reached the destination vertex, the algorithm is finished. 

(b) Prim's algorithm will have 2 arrays. One for keeping track if the vertext is in the tree and another to keep the value of the lowest edge weight to that vertext. The algorithm will start at an arbitrary place and then choose the minimum edge of all the edges from the vertex where the chosen edge does not include both vertices that have already been visited. Once the edge is chosen, it will go to the vertex connected to the chosen edge and repeat the process until the destination vertex has been visited.

(a & b) The spanning forest would be to just display the steps that are taken to arrive at the minimum spanning tree. So for each successful edge that is chosen, it will go display the results. 

(c) Use either of the algorithms in a or b.

(d) For this you would use Dijsktra's algorithm to find the maximum sum of edges to the destination vertex. Dijsktra's algorithm will hold an array of all the vertices and their respective vertex value. Then it will have another array that will hold the sum of each value at each vertex in the vertex value array. It will go through the entire set of vertices and for each vertex it will take the total of the vertex it is visiting (the max sum of edge values needed to get to that vertex) and the value of the edge that is connected to the neighboring vertex. At the end return the value that is the index of the destination vertex that is given. 
</p>
</details>

---

6-2. Is the path between two vertices in a minimum spanning tree necessarily a shortest path between the two vertices in the full graph? Give a proof or a counterexample.

<details>
  <summary>**ANSWER**</summary>
  <p>  

No.

Given a graph G(V,E,W) = ((A,B,C,D),({A,B},{B,C},{C,D},{D,A}),(1,2,3,2))

Minimum spanning tree has a weight of 6 with edges {A,B},{B,C},{C,D}.

In the full graph the minimum distance between A and D is 2.
  
  </p>
</details>

---

6-3. Assume that all edges in the graph have distinct edge weights (i.e., no pair of edges have the same weight). Is the path between a pair of vertices in a minimum spanning tree necessarily a shortest path between the two vertices in the full graph? Give a proof or a counterexample.
<details>
  <summary>**ANSWER**</summary>
  <p>
  
No.

Given a graph G(V,E,W) = ((A,B,C,D),({A,B},{B,C},{C,D},{D,A}),(1,2,3,4))

Minimum spanning tree has a weight of 6 with edges {A,B},{B,C},{C,D}.

The shortest path from A to D is 4.
  
</p>
</details>

---

6-4. Can Prim's and Kruskal's algorithm yield different minimum spanning trees? Explain why or why not.


<details>
  <summary>**ANSWER**</summary>
  <p>
  
  Yes.

Because Kruskal's uses a priority queue while Prim's starts at an arbitrary point and gets the minimum. So say there are 2 edges with the same weight to a vertex, whichever Kruskal's chooses first in its sorting of the priority queue and whichever Prim's vertex's neighbor is will be the deciding factor.  
  
</p>
</details>

---

6-5. Does either Prim's and Kruskal's algorithm work if there are negative edge weights? Explain why or why not.


<details>
  <summary>**ANSWER**</summary>
  <p>
  
  Yes because it chooses the minimum edge that is available. It is Dijsktra's algorithm that does not work with negative edge weights.
  
</p>
</details>

---

6-6. Suppose we are given the minimum spanning tree T of a given graph G (with n vertices and m edges) and a new edge e=(u,v) of weight w that we will add to G. Give an efficient algorithm to find the minimum spanning tree of the graph G+e. Your algorithm should run in O(n) time to receive full credit.


<details>
  <summary>**ANSWER**</summary>
  <p>
  
  Adding an edge to an already existing vertices in the graph is simple. You only have to decided whether the new edge has a weight less than the edge connected to the vertex u or vertex v. Then if it is smaller than both, pick the greatest to replace it. If it is smaller than only one of them then replace that one. 
  
</p>
</details>

---

6-7. 
(a) Let T be a minimum spanning tree of a weighted graph G. Construct a new graph G′ by adding a weight of k to every edge of G. Do the edges of T form a minimum spanning tree of G′? Prove the statement or give a counterexample. 
(b) Let P={s,…,t} describe a shortest weighted path between vertices s and t of a weighted graph G. Construct a new graph G′ by adding a weight of k to every edge of G. Does P describe a shortest path from s to t in G′? Prove the statement or give a counterexample.


<details>
  <summary>**ANSWER**</summary>
  <p>
  
  (a) Depends on the weight of k. if (k * numOfEdges in T <= sum of T) then yes

From online: Probably yes. Using Kruskal's algorithm, you'll still get the same insertion order of edges, regardless of how much you add or subtract from the edge weighting.



(b) Depends on the weight of k. if (k * numOfEdges in P <= sum of P) then yes
	
From online: No. Example would be the following graph:

A -1-> B B -1-> C A -3-> C

Shortest path from A to C is A->B->C.

If we increase all weights by two, shortest path will change to A->C
  
</p>
</details>

---

6-8. Devise and analyze an algorithm that takes a weighted graph G and finds the smallest change in the cost to a non-MST edge that would cause a change in the minimum spanning tree of G. Your algorithm must be correct and run in polynomial time.


<details>
  <summary>**ANSWER**</summary>
  <p>
  
  Start at a vertex A, get the minimum edge, find edges from vertex A to other vertices that are not already in the tree, get the minimum of those edges, subtract that edge from the already minimum edge and add 1 to get the total difference needed. Put that in minimum cost array (which will be initialized with MaxInt). Do this for every vertex. Then iterate through the minimum cost array to find the smallest value. This will take O(n) time. 
  
</p>
</details>

---

6-9. Consider the problem of finding a minimum weight connected subset T of edges from a weighted connected graph G. The weight of T is the sum of all the edge weights in T.

(a) Why is this problem not just the minimum spanning tree problem? Hint: think negative weight edges.

(b) Give an efficient algorithm to compute the minimum weight connected subset T.


<details>
  <summary>**ANSWER**</summary>
  <p>
  
  (a) If there are negative edges then you will want to include ALL negative edges to drive down the connected subset. Also note that the connected subset does not say it is a minimum spanning tree thus you can have more than one n-1 edges connecting the tree.

(b) Algorithm would be to find all the negative edges, put those in the tree, then do kruskals or prims algorithm.
  
</p>
</details>


