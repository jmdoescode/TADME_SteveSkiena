6-10. Let G=(V,E) be an undirected graph. A set F⊆E of edges is called a feedback-edge set if every cycle of G has at least one edge in F.

(a) Suppose that G is unweighted. Design an efficient algorithm to find a minimum-size feedback-edge set.
(b) Suppose that G is a weighted undirected graph with positive edge weights. Design an efficient algorithm to find a minimum-weight feedback-edge set.

[Feedback arc set via Wikipedia](https://en.wikipedia.org/wiki/Feedback_arc_set)

<details>
<summary>**ANSWER**</summary>
  <p>
  
  (a) **Minimum Size Feedback-Edge Set**: Use DFS to meet the feedback-edge starting from any vertex. Add it to the result set. When DFS completes, the result set is the answer.

  (b) **Minimum Weight Feedback-Edge Set**: Invert all the weight values in the graph. Then run Kruskal's algorithm. This will return a maximum-spanning tree. All edges that are not in the maximum-spanning tree are added to a result set which is the minimum-weight feedback-edge set. 
  
  </p>
</details>