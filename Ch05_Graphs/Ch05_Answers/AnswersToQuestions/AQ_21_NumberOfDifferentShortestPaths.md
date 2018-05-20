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

