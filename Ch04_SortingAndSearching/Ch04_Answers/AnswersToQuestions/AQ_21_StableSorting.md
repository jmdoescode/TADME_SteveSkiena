4-21. Stable sorting algorithms leave equal-key items in the same relative order as in the original permutation. Explain what must be done to ensure that mergesort is a stable sorting algorithm.


<details>
<summary>**ANSWER**</summary>
  <p>

    The one you're merging on the left goes first (lower indexed value of the tie will go first)

    ---------------------------------------------------

    To guarantee mergesort is stable, when merging the two subarrays together, mergesort should settle ties in the lists by choosing the lower indexed value.
  
  </p>
</details>
