# Chapter 6 Notes

---

## ALGORITHMS

### What is Prim's Algorithm?

<details>
<summary>**Prim's Algorithm**</summary>
  <p>

It is an algorithm used to find the minimum spanning tree of a set.

Steps:
- Select arbitrary vertex to start the tree from.
- While(there are still nontree vertices).
  - Select the edge of minimum weight between a tree and nontree vertex.
  - Add selected edge and vertex to the tree Tprim.

Time complexity is O(mn).

  </p>
</details>


### What is Kruskal's Algorithm?

<details>
<summary>**Kruskal's Algorithm**</summary>
  <p>

It is an algorithm used to find the minimum spanning tree of a set. For this algorithm, a component is one vertex or a set of connected vertices (aka a tree).

Steps:
- Insert the weights of each edge in a priority queue which hold the start and end vertices(sorting can take O(lg n) time).
- While count of edges < num of edges - 1.
  - Get next edge.
  - If the start and end vertices are not in the same component, then merge them together.

Time complexity is O(mn)
  - Sorting m edges takes O(m lg m)
  - The component test takes O(n) time
	
But with the **union-find data structure** it will run in O(m lg m) time 
  - This is because the component test can be done in O(lg n) instead of O(n) time 

  </p>
</details>


### What is the data structure used in Kruskal's Algorithm? Explain it.

<details>
<summary>**Data structure used in Kruskal's Algorithm**</summary>
  <p>

The data structure is the Union-Find data structure (also called a Disjoint-Set or Merge-Find set).
- It is a data structure that tracks a set of elements partitioned into a number of disjoint subsets.
- A disjoint-set forest consists of a number of elements each of which stores an id, a parent pointer, and either a size or a rank value. 
- The parent pointers of elements are arranged to form one or more components (aka a tree), each representing a set. If an element's parent points to itself then it is the root of the component.

Main operations are:
- Find: Follows the chain of parent pointers from x until it reaches a root element (the parent is the same as the element). 
  - Can also contain **Path Compression** which flattens the structure by making every child node of the parent point to the parent.
- Union: Uses *Find* to determine the roots of the components that x and y belong to. If the roots are not equal to each other then the components merge together. 
  - You can union the smaller component to the larger one.

Time Complexity
  - Find and union can take O(log n) time. [Source here](https://en.wikipedia.org/wiki/Proof_of_O(log*n)_time_complexity_of_union–find)
  </p>
</details>



### What is Dijsktra's Algorithm?

<details>
<summary>**Dijsktra's Algorithm**</summary>
  <p>

The algorithm is used to find the shortest path between two vertices.

Steps:
- Keep track of vertices you visited and their minimum distances.
- For each vertex, visit all edges that exist for it.
  - Keep track of the lowest sum of edges to each vertex.
    - To get the lowest sum of the edge, add the weight of the current vertex to the weight of the next vertex and compare it to it's current lowest value.
- You will now have the lowest value to get to any vertex from the starting vertex.
- Return the value at the destination vertex. 

Time complexity is O(n).

  </p>
</details>



### What is Floyd's Algorithm?

<details>
<summary>**Floyd's Algorithm**</summary>
  <p>

The algorithm is used to find the shortest path between two vertices. It uses an adjacency matrix. It finds the smallest distance for each vertex from x to y while comparing through each other vertex.

Steps:
- For each vertex k in the adjacency matrix
  - For each vertex x in the adjacency matrix
    - For each vertex y in the adjacency matrix
	  - Get the value of through_k which is: The sum of the distances from x to k and from k to y
	  - Distance to y equals the minimum distance from x to y or through_k
- Return the value at the destination vertex (y)

Time complexity is O(n^3).

  </p>
</details>