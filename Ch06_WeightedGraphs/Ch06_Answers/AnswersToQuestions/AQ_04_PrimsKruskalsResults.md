6-4. Can Prim's and Kruskal's algorithm yield different minimum spanning trees? Explain why or why not.


<details>
  <summary>**ANSWER**</summary>
  <p>
  
  Yes.

Because Kruskal's uses a priority queue while Prim's starts at an arbitrary point and gets the minimum. So say there are 2 edges with the same weight to a vertex, whichever Kruskal's chooses first in its sorting of the priority queue and whichever Prim's vertex's neighbor is will be the deciding factor.  
  
</p>
</details>

