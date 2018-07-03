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


---

6-10. Let G=(V,E) be an undirected graph. A set F⊆E of edges is called a feedback-edge set if every cycle of G has at least one edge in F.

(a) Suppose that G is unweighted. Design an efficient algorithm to find a minimum-size feedback-edge set.
(b) Suppose that G is a weighted undirected graph with positive edge weights. Design an efficient algorithm to find a minimum-weight feedback-edge set.

[Feedback arc set via Wikipedia](https://en.wikipedia.org/wiki/Feedback_arc_set)

<details>
<summary>**ANSWER**</summary>
  <p>
  
  (a) **Minimum Size Feedback-Edge Set**: Use DFS to meet the feedback-edge starting from any vertex. Add it to the result set. When DFS completes, the result set is the answer.

  (b) **Minimum Weight Feedback-Edge Set**: Invert all the weight values in the graph. Then run Kruskal's algorithm. This will return a maximum-spanning tree. All edges that are not in the maximum-spanning tree are added to a result set which is the minimum-weight feedback-edge set. 
  
  </p>
</details>

---

6-11. Modify Prim's algorithm so that it runs in time O(n log k) on a graph that has only k different edges costs.

Extra: Explain Prim's algorithm.

<details>
<summary>**ANSWER**</summary>
  <p>

  Firstly, Prim's algorithm is a greedy algorithm in which, starting at a vertex, it chooses the edge of minimum weight where the starting vertex is already in the tree and the destination vertex is not already in the tree. This is also assuming that the very first vertex at the beginning of the algorithm gets put into the tree automatically. 

  Start at any vertex. Insert all edges of that vertex into a min-heap. Each node of the min-heap will have a value that is equal to the weight of the edge and will also include a linked list of all destination vertices. Do this for all edges of each vertex where the edge is not already in the min-heap. Once min-heap is finished you will iterate through the min-heap while min-heap is not empty. Take out the minimum edge (the first value of min-heap) and remove the destination vertex from the list IF the vertex does not already exist in the tree and add it to the result tree. If you come across a destination vertex that is already in the result tree, remove it from the min-heap. 

  Iterating through all vertices will take n time. Creating the min-heap will take n * log k time. Iterating through min-heap to create result tree will take n * log k time. Total time will be O(n * log k) time. 

  </p>
</details>

---

6-12. Devise an efficient data structure to handle the following operations on a weighted directed graph:

(a) Merge two given components.
(b) Locate which component contains a given vertex v.
(c) Retrieve a minimum edge from a given component.


<details>
<summary>**ANSWER**</summary>
  <p>

  Create a union-find data structure. Your data structure will include these properties:

  - An array of Vertices that holds the Vertex at a given index. It does not matter what order they are in as long as you know what the value of the node is at the index. For example: index of 0 holds node A, index of 1 holds node D, etc...
  - An array for Parents of the Vertices (this will be the parent of the given component (the component of the index can be found using the Vertices array) - if the parent value is the same as the component value then it is either the root or it is an individual component).
  - An array for the Component's Size (this will be how many components are unioned to the root).
  - An int value for the number of components in the data structure (should be initialized to the number of vertices).
  - An int value for the size of the data structure (the number of elements in the data structure).
  - An array to hold the minimum weight of a component at the root.


  (a) To merge two components:

  - Create a void method, this will be your union method, which takes two ints as paramenters (one for index of Component A and one for index of Component B). 
  - Find the roots for component A and B. 
  - If the roots are the same return nothing. 
  - Merge the smallest of the two components to the biggest one; you will also need to increase the size of the larger component as well as change the parent for the smaller component to that of the larger component. You will also need to update the minimum weight array and whichever value is smaller update the value at the root. 
  - Then you need to decrease the number of components since they were just merged.

  (b) To locate which component contains a given vertex v:

  - Create an int method, this will be your find method, which takes the index of the component as the parameter.
  - Get the root of the component. The root is found with a while loop that gets the parent of the component until the parent of the index of component is the same as the index of the component. So until root == parent[root].
  - Then you compress the data strucure by making all the parent's (from the index of the component to the root) the same value as the root. This way all the components will have the same root value and it takes only one stop to get the root rather than follow more than one value to get to the root.
  - Then return the root.

  (c) Retrieve a minimum edge from a given component.

  - Create an int method, this will be your minimum edge of component method which will take the index of any part of the component.
  - Get the root by finding the parent of the index of the component.
  - Get the value of minimum weight array passing in the root as the index.
  - Return the value.

	
  </p>
</details>

---

6-13. Design a data structure that can perform a sequence of, m union and find operations on a universal set of n elements, consisting of a sequence of all unions followed by a sequence of all finds, in time O(m+n).


<details>
<summary>**ANSWER**</summary>
  <p>

  Union Sequence

  - First create a method that takes in a list of all edges to be unioned. 
  - For each edge in the list call the Find operation from Question 12 passing in the index of start vertex and index of the destination vertex. 

  Find Sequence

  - Next create another method that takes a params array of the index of each component to be found.
  - For each item in the array do the find operation as was mentionded in Question 12. 

  </p>
</details>

---

6-14. The single-destination shortest path problem for a directed graph seeks the shortest path from every vertex to a specified vertex v. Give an efficient algorithm to solve the single-destination shortest paths problem.


<details>
<summary>**ANSWER**</summary>
  <p>

A simple solution would be to run Dijsktra's or Floyd's algorithm for each vertex. Create a method that will return a dictionary where the key is the starting vertex and the value is the shortest path. In the method you would calculate the shortest path for each vertex and after getting a result for one vertex, insert it into the dictionary. 

  </p>
</details>

---

6-15. Let G=(V,E) be an undirected weighted graph, and let T be the shortest-path spanning tree rooted at a vertex v. Suppose now that all the edge weights in G are increased by a constant number k. Is T still the shortest-path spanning tree from v?


<details>
<summary>**ANSWER**</summary>
  <p>

  No. The sum of multiple edges could outweight another path with shorter edges. 

  ![alt text](../../Ch06_Pictures/6_AQ_16_01.jpg "Figure_01")

  </p>
</details>

---

6-16. Answer all of the following:

(a) Give an example of a weighted connected graph G=(V,E) and a vertex v, such that the minimum spanning tree of G is the same as the shortest-path spanning tree rooted at v.

(b) Give an example of a weighted connected directed graph G=(V,E) and a vertex v, such that the minimum-cost spanning tree of G is very different from the shortest-path spanning tree rooted at v.

(c) Can the two trees be completely disjointed?

<details>
<summary>**ANSWER**</summary>
  <p>

  ![alt text](../../Ch06_Pictures/6_AQ_16_01.jpg "Figure_01")

  (c) No, because a minimum spanning tree must touch all vertices.

  </p>
</details>

---

6-17. Either prove the following or give a counterexample:

(a) Is the path between a pair of vertices in a minimum spanning tree of an undirected graph necessarily the shortest (minimum weight) path?

(b) Suppose that the minimum spanning tree of the graph is unique. Is the path between a pair of vertices in a minimum spanning tree of an undirected graph necessarily the shortest (minimum weight) path?

<details>
<summary>**ANSWER**</summary>
  <p>

  (a) No. Shortest path is the lowest sum of all paths to a vertex. An edge between vertex A to vertex Z could be weight 20 while the minimum spanning tree sum could be 150 going through multiple vertices. ([See question 6-2](/Ch06_Answers/AnswersToQuestions/AQ_02_MinimumEdge.md)).

  (b) No. Same as (a).

  </p>
</details>

---

6-18. In certain graph problems, vertices have can have weights instead of or in addition to the weights of edges. Let Cv be the cost of vertex v, and C(x,y) the cost of the edge (x,y). This problem is concerned with finding the cheapest path between vertices a and b in a graph G. The cost of a path is the sum of the costs of the edges and vertices encountered on the path.

(a) Suppose that each edge in the graph has a weight of zero (while non-edges have a cost of ∞). Assume that Cv=1 for all vertices 1≤v≤n (i.e., all vertices have the same cost). Give an efficient algorithm to find the cheapest path from a to b and its time complexity.

(b) Now suppose that the vertex costs are not constant (but are all positive) and the edge costs remain as above. Give an efficient algorithm to find the cheapest path from a to b and its time complexity.

(c) Now suppose that both the edge and vertex costs are not constant (but are all positive). Give an efficient algorithm to find the cheapest path from a to b and its time complexity.


<details>
<summary>**ANSWER**</summary>
  <p>

  (a) Simply use Dijsktra's algorithm. Time complexity is O(n^2).

  (b) Simply use Dijsktra's algorithm but change it to sum the weight of vertices. Time complexity is O(n^2).

  (c) Simply use Dijsktra's algorithm but change it to take into account vertices as well. Time complexity is O(n^2).

  </p>
</details>

---


6-19. Let G be a weighted directed graph with n vertices and m edges, where all edges have positive weight. A directed cycle is a directed path that starts and ends at the same vertex and contains at least one edge. Give an O(n3) algorithm to find a directed cycle in G of minimum total weight. Partial credit will be given for an O(n2m) algorithm.


<details>
<summary>**ANSWER**</summary>
  <p>

  Simply use Floyd's algorithm where the start and destination vertex are the same. 

  </p>
</details>

---

