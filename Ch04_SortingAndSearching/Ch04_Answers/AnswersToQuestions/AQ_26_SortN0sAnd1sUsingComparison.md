4-26. Consider the problem of sorting a sequence of n 0's and 1's using comparisons. For each comparison of two values x and y, the algorithm learns which of x<y, x=y, or x>y holds.

Give an algorithm to sort in n−1 comparisons in the worst case. Show that your algorithm is optimal.  
Give an algorithm to sort in 2n/3 comparisons in the average case (assuming each of the n inputs is 0 or 1 with equal probability). Show that your algorithm is optimal.  


<details>
<summary>**ANSWER**</summary>
  <p>

	Choose a random pivot, it will either be 0 or 1; then do the remaining comparisions around it.  
    Worst case is n-1 comparisions needed.
  
  </p>
</details>
