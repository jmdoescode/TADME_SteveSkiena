5-23. Your job is to arrange n ill-behaved children in a straight line, facing front. You are given a list of m statements of the form i hates j. If i hates j, then you do not want put i somewhere behind j, because then i is capable of throwing something at j.

(a) Give an algorithm that orders the line, (or says that it is not possible) in O(m+n) time.

(b) Suppose instead you want to arrange the children in rows such that if i hates j, then i must be in a lower numbered row than j. Give an efficient algorithm to find the minimum number of rows needed, if it is possible.

<details>
<summary>**ANSWER**</summary>
  <p>

(a) Create a directed graph with the vertices representing the children and the edges representing the "i hates j" relations and use topological sorting. This will either give out a list representing the order in the line or tell you if it's not possible, i.e. a cycle is in the graph.

(b) Build a BFS graph from the directecd graph as built in the previous task. The maximum depth of this graph is the number of rows necessary.

  </p>
</details>