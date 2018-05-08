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


