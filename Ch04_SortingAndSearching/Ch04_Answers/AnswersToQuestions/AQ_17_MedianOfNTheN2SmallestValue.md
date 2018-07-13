4-17. The median of a set of n values is the ⌈n/2⌉th smallest value.

Suppose quicksort always pivoted on the median of the current sub-array. How many comparisons would Quicksort make then in the worst case?  
Suppose quicksort were always to pivot on the ⌈n/3⌉th smallest value of the current sub-array. How many comparisons would be made then in the worst case?  


<details>
<summary>**ANSWER**</summary>
  <p>

    (a)  
        half

    (b)  
        Let F(n) be the number of compares for a quicksort of size n, split into a section of size 1/3 and a section of size 2/3. The recurrence relation would be:

        F(n) = n/3 + 2n/3 + F(n/3) + F(2n/3) = n + F(n/3) + F(2n/3)

        In other words, the number of compares at size n is equal to the number of compares to do a top level partition (1/3 for one side, 2/3 for the other side), plus the number of compares to quicksort the 1/3 partition and the 2/3 partition.

  </p>
</details>