5-19. The diameter of a tree T=(V,E) is given by max u,v∈Vδ(u,v) (where δ(u,v) is the number of edges on the path from u to v). Describe an efficient algorithm to compute the diameter of a tree, and show the correctness and analyze the running time of your algorithm.

The diameter of a tree (sometimes called the width) is the number of nodes on the longest path between two end nodes.


<details>
<summary>**ANSWER**</summary>
  <p>

  Summary

- Start at the root node.
- Pass in root node and a reference int answer to the function.
- Get the height of the left using recursion by passing in the left node of the root node.
- Get the height of the right using recursion by passing in the right node of the root node.
- Update the answer which is equal to the max of the answer vs (1 + left_height + right height)
- The function returns 1 + max(left_height + right_height)
- The int variable answer is the correct answer to the height of the tree. 

  </p>
</details>



