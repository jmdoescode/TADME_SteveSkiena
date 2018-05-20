5-26. A mother vertex in a directed graph G=(V,E) is a vertex v such that all other vertices G can be reached by a directed path from v.

(a) Give an O(n+m) algorithm to test whether a given vertex v is a mother of G, where n=|V| and m=|E|.

(b) Give an O(n+m) algorithm to test whether graph G contains a mother vertex.


<details>
<summary>**ANSWER**</summary>
  <p>

  (a) Summary
  - Start at vertex v
  - You will need a Dictionary where the vertex is the key and true/false is the value. 
	- Initialize dictionary with all vertices and set all to false except v.
  - Do a BFS from v where you can only add nodes to the queue if they are reachable from the nodes in your queue. 
    - Start from source (v) to destination. For each destination vertex you visit change the dictionary value to true.
    - Destination changes to source. Repeat previous step.
  - At the end of BFS iterate through dictionary to see if any values are false.
    - If any values are false then v is not a mother.
  - Should take O(3(n) + m) which boils down to O(n + m).

  (b) Summary
  - Start at any vertex and do a BFS/DFS algorithm and keep a list of the last finished vertex.
  - If there exists a mother vertex then it must be in the list. Do a BFS/DFS to find if it is true (use the algorithm in step (a) for each vertex in the list).


  </p>
</details>