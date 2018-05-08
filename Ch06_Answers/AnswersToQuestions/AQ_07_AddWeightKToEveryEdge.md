6-7. 
(a) Let T be a minimum spanning tree of a weighted graph G. Construct a new graph G′ by adding a weight of k to every edge of G. Do the edges of T form a minimum spanning tree of G′? Prove the statement or give a counterexample. 
(b) Let P={s,…,t} describe a shortest weighted path between vertices s and t of a weighted graph G. Construct a new graph G′ by adding a weight of k to every edge of G. Does P describe a shortest path from s to t in G′? Prove the statement or give a counterexample.


**ANSWERS**

(a) Depends on the weight of k. if (k * numOfEdges in T <= sum of T) then yes

From online: Probably yes. Using Kruskal's algorithm, you'll still get the same insertion order of edges, regardless of how much you add or subtract from the edge weighting.



(b) Depends on the weight of k. if (k * numOfEdges in P <= sum of P) then yes
	
From online: No. Example would be the following graph:

A -1-> B B -1-> C A -3-> C

Shortest path from A to C is A->B->C.

If we increase all weights by two, shortest path will change to A->C
