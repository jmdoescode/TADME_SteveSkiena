6-8. Devise and analyze an algorithm that takes a weighted graph G and finds the smallest change in the cost to a non-MST edge that would cause a change in the minimum spanning tree of G. Your algorithm must be correct and run in polynomial time.


**ANSWER**

Start at a vertex A, get the minimum edge, find edges from vertex A to other vertices that are not already in the tree, get the minimum of those edges, subtract that edge from the already minimum edge and add 1 to get the total difference needed. Put that in minimum cost array (which will be initialized with MaxInt). Do this for every vertex. Then iterate through the minimum cost array to find the smallest value. This will take O(n) time. 