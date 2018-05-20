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