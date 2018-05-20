5-29. Following up on the previous problem, give an O(n+m) algorithm that finds a deletion order for the n vertices such that no deletion disconnects the graph. (Hint: think DFS/BFS.)

<details>
<summary>**ANSWER**</summary>
  <p>

  Summary:
  - Use logic from 5-28. Delete any vertex that is not in the output of 5-28. Run 5-28 algorithm again to refresh list and then repeat.

  </p>
</details>