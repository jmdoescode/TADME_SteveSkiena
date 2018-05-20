5-12. The square of a directed graph G=(V,E) is the graph G2=(V,E2) such that (u,w)∈E2 iff there exists v∈V such that (u,v)∈E and (v,w)∈E; i.e., there is a path of exactly two edges from u to w. square of a graph Give efficient algorithms for both adjacency lists and matrices. 

<details>
<summary>**ANSWER**</summary>
  <p>

  To compute ***G<sup>2</sup>***

**Adjacency list**

    for each vertex in the adjacency list of node u
        for each vertex in the adjacency list of node v
            edge(u,w) exists in G2 iff edge(u,v) and edge(v,w) exist in G
                if so, add vertex w to the adjacency list of edge u 

This should be possible in time *(O(VE)*.

**Adjacency matrix**

The adjacency matrix of graph *G<sup>2</sup>* is the graph obtained by squaring the adjacency matrix of graph *G*.
This is possible in time *O(V<sup>3</sup>)*. 

  </p>
</details>
