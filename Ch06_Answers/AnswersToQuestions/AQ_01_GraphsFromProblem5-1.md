6-1. For the graphs in Problem (see book):

(a) Draw the spanning forest after every iteration of the main loop in Kruskal's algorithm. 

(b) Draw the spanning forest after every iteration of the main loop in Prim's algorithm.

(c) Find the shortest path spanning tree rooted in A.

(d) Compute the maximum flow from A to H.

A spanning forest being a forest that spans all of the vertices, meaning only that each vertex of the graph is a vertex in the forest. For this definition even a connected graph may have a disconnected spanning forest, such as the forest in which each vertex forms a single-vertex tree.


**ANSWER**

(a) Kruskal's algorithm uses a priority queue from lowest to highest value and then uses a union find data structure to find the minimal spanning tree. It goes through each edge and finds whether the component 1 already exists within a tree of component 2 and vice versa (this will prevent creation of cycles). If the components are not in the same tree then the algorithm will union the two components together. Once there are no more components to match and the algorithm has reached the destination vertex, the algorithm is finished. 

(b) Prim's algorithm will have 2 arrays. One for keeping track if the vertext is in the tree and another to keep the value of the lowest edge weight to that vertext. The algorithm will start at an arbitrary place and then choose the minimum edge of all the edges from the vertex where the chosen edge does not include both vertices that have already been visited. Once the edge is chosen, it will go to the vertex connected to the chosen edge and repeat the process until the destination vertex has been visited.

(a & b) The spanning forest would be to just display the steps that are taken to arrive at the minimum spanning tree. So for each successful edge that is chosen, it will go display the results. 

(c) Use either of the algorithms in a or b.

(d) For this you would use Dijsktra's algorithm to find the maximum sum of edges to the destination vertex. Dijsktra's algorithm will hold an array of all the vertices and their respective vertex value. Then it will have another array that will hold the sum of each value at each vertex in the vertex value array. It will go through the entire set of vertices and for each vertex it will take the total of the vertex it is visiting (the max sum of edge values needed to get to that vertex) and the value of the edge that is connected to the neighboring vertex. At the end return the value that is the index of the destination vertex that is given. 
