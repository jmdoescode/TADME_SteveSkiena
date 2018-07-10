4-10. Given a set S of n integers and an integer T, give an O(n^(k−1) logn) algorithm to test whether k of the integers in S add up to T. 

<details>
<summary>**ANSWER**</summary>
  <p>

If unsorted sort first.  
Find the value of T with binary search.  
This will be your upper bound.  
Subtract first from T.  
&nbsp;&nbsp;&nbsp;&nbsp;Binary Search for that difference.  

and repeat 


  </p>
</details>