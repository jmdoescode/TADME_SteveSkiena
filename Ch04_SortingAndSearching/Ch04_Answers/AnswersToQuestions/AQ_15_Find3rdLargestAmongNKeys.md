4-15. (a) Give an efficient algorithm to find the second-largest key among n keys. You can do better than 2n−3 comparisons. (b) Then, give an efficient algorithm to find the third-largest key among n keys. How many key comparisons does your algorithm do in the worst case? Must your algorithm determine which key is largest and second-largest in the process?


<details>
<summary>**ANSWER**</summary>
  <p>

1) You could max heapify the entire array of keys which takes O(n) time and then the elements below are either the second or third largest and you just compare those two.

2) You can scan through the array of keys keeping max1, max2, and max3 variables and comparing them against the newest key.

  </p>
</details>