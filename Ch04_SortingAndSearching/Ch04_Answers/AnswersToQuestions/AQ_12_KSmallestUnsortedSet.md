4-12. Devise an algorithm for finding the k smallest elements of an unsorted set of n integers in O(n+klogn).

<details>
<summary>**ANSWER**</summary>
  <p>

Scan through the array to build an out-of-order heap, that is, the first element is indeed the smallest, but necessarily any of the other elements. This takes us O(n).  
Then extract from the heap k times to get the smallest k elements using O(klogn).  
Thus the total time is O(n+klogn).  

  </p>
</details>