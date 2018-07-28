4-29. Mr. B. C. Dull claims to have developed a new data structure for priority queues that supports the operations Insert, Maximum, and Extract-Max---all in O(1) worst-case time. Prove that he is mistaken. (Hint: the argument does not involve a lot of gory details---just think about what this would imply about the Ω(nlogn) lower bound for sorting.)


<details>
<summary>**ANSWER**</summary>
  <p>

    If this claim was true one could construct a linear time sorting algorithm by inserting all elements and then extracting all maximum elements again. Since the lower bound of O(n log n) for searching this is not possible.
  
  </p>
</details>
