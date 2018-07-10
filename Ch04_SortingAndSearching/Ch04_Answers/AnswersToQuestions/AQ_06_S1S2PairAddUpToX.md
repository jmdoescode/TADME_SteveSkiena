4.6 Given two sets S1 and S2(each of size n), and a number x, describe an O(n log n) algorithm for finding whether there exists a pair of elements, one from S1 and one from S2, that add up to x. (For partial credit, give a Θ(n2) algorithm for this problem.)


<details>
<summary>**ANSWER**</summary>
  <p>

1. Sort S1; O(n log n)
2. for i=0 to n-1  
    val = x - S2[i]  
    if binary_search(S1, val) O(log n)  
	&nbsp;&nbsp;&nbsp;&nbsp;return (val, S2[i])  
End Loop

  </p>
</details>