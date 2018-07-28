4-23. We seek to sort a sequence S of n integers with many duplications, such that the number of distinct integers in S is O(logn). Give an O(nloglogn) worst-case time algorithm to sort such sequences.


<details>
<summary>**ANSWER**</summary>
  <p>

	With a self-balancing binary search tree, we can achieve O(log k) search and insertion (where k is the number of elements in the tree).
    
    1. For each element in the sequence S, try and insert it into the tree.  
    - If the element is present, we increment a count variable stored at a node.  
    - If the element is not present, we insert the node and set the count = 1.  

    2. Traverse the tree in order and add elements according to the count.

    Since the tree is guaranteed not to exceed log n elements, search and insertion take O(log log n).  
    Thus, this entire algorithm takes O(n * log log n + log n) = O(n * log log n) as required.  

  
  </p>
</details>
