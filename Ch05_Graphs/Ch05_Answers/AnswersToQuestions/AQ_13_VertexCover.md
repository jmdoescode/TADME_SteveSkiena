5-13. A vertex cover of a graph G=(V,E) is a subset of vertices V′ such that each edge in E is incident on at least one vertex of V′.

(a) Give an efficient algorithm to find a minimum-size vertex cover if G is a tree.

(b) Let G=(V,E) be a tree such that the weight of each vertex is equal to the degree of that vertex. Give an efficient algorithm to find a minimum-weight vertex cover of G.

(c) Let G=(V,E) be a tree with arbitrary weights associated with the vertices. Give an efficient algorithm to find a minimum-weight vertex cover of G.

Sources: 
	https://en.wikipedia.org/wiki/Vertex_cover
	
<details>
<summary>**ANSWER**</summary>
  <p>
  
(a) The problem of finding a minimum vertex cover is a classical optimization problem in computer science and is a typical example of an NP-hard optimization problem that has an approximation algorithm.

- Endpoints and parents will not be needed.
- Also if a node shares children or if a child of a node is another node's parent then that is not needed as well.

An effecient algorithm for this would be (for a tree):

- You can do this as a BFS.
- Start at the root.
- While the current node has children and it is not a leaf node, iteratedown.
- Add node to Minimum Vertex List. 
- Change current node to child node.
- Repeat while loop.

(b) A leaf is each 1 degree. This means that the parent's weight is the number of children + 1. We thus remove the parent and include the leaves. Then repeat.

(c) We know we will be able to remove at most one every other node, so we use a two-coloring technique (Red/Black) and perform a post-order traversal. Let's assume we will remove all the Black node. When we process a node, we also store with each node the sum over its immediate children of the respective Red and Black weight for the subtree. If not all of the children are Red, we need to mark the current node as Red. But we also have the option to reverse the coloring of all the Red-children's subtree. So we look at the sum over the red-children for Red and Black, and compare the difference of these sum to the current node's weight. If the current node's weight is above, we swap the coloring for these subtree. The current node will record the Black and Red sum of its children's subtree, and add its own weight to its color. 

  </p>
</details>
