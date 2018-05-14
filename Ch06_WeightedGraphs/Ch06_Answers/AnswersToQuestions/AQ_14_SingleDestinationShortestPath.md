6-14. The single-destination shortest path problem for a directed graph seeks the shortest path from every vertex to a specified vertex v. Give an efficient algorithm to solve the single-destination shortest paths problem.


<details>
<summary>**ANSWER**</summary>
  <p>

A simple solution would be to run Dijsktra's or Floyd's algorithm for each vertex. Create a method that will return a dictionary where the key is the starting vertex and the value is the shortest path. In the method you would calculate the shortest path for each vertex and after getting a result for one vertex, insert it into the dictionary. 

  </p>
</details>