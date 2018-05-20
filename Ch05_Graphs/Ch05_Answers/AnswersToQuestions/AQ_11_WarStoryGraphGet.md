5-11. The war story of Section 5.4 (page 158) describes an algorithm for constructing
            the dual graph of the triangulation efficiently, although it does not guarantee linear
            time. Give a worst-case linear algorithm for the problem.

    Consider the representation of data, the same way as in the war story.
    i.e a number vertices, and Triangles mentioned as a set of 3 vertices.

<details>
<summary>**ANSWER**</summary>
  <p>
  
  [Answer Here](../../Ch05_Answers/AnswersToQuestions/AQ_11_WarStoryGraphGet.cs)

  We will keep one adjacency Matrix. This matrix will tell whether or not an edge exists. If an edge exists, the matrix contains the pointer to the element representing the edge. Initially the Matrix is empty and have no idea about the edges. We will maintain an array of edges. Every element of this array will basically point to a list of triangles, that contain that edge. (This is similar to an adjacency list, where every vertex maintains a list of adjacent vertices). 
  
  For example:
 
 e1 -> T4   (Edge 1 is contained in Triangle 4)
 
 e2 -> T3   (Edge 2 is contained in Triangle 3)..

Now when we read a triangle, for every edge we check if that edge element is present in the Matrix. If so, the Matrix contains the pointer to the edge element. This edge element can be present in only 1 other Triangle. So we immediately get The triangle sharing the edge. This way we can get all adjacent Triangles (Max 3, one for each edge) for every triangle in constant time. For n triangles, this gives O(n) running time.

  </p>
</details>