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