4-2. For each of the following problems, give an algorithm that finds the desired numbers within the given amount of time. To keep your answers brief, feel free to use algorithms from the book as subroutines. For the example, S={6,13,19,3,8}, 19−3 maximizes the difference, while 8−6 minimizes the difference. 

(a) Let S be an unsorted array of n integers. Give an algorithm that finds the pair x,y∈S that maximizes |x−y|. Your algorithm must run in O(n) worst-case time. 

(b) Let S be a sorted array of n integers. Give an algorithm that finds the pair x,y∈S that maximizes |x−y|. Your algorithm must run in O(1) worst-case time. 

(c) Let S be an unsorted array of n integers. Give an algorithm that finds the pair x,y∈S that minimizes |x−y|, for x≠y. Your algorithm must run in O(nlogn) worst-case time. 

(d) Let S be a sorted array of n integers. Give an algorithm that finds the pair x,y∈S that minimizes |x−y|, for x≠y. Your algorithm must run in O(n) worst-case time.

<details>
<summary>**ANSWER**</summary>
  <p>

(a) Iterate through the array keeping a |min| and |max| variables and subtract at the end

(b) You need to get S[0] and S[n-1]

(c) Sort the array with any nlog(n) method. Then scan through the sorted array to find the smallest gap, thus the desired pair.
You can also do this in O(2n) time. Iterate through array once to get the minimum as minimum1. Then iterate through again to get the minimum2 that is greater than minimum1.

(d) Get S[n-1] and S[n-2] if the sort is descending. 

  </p>
</details>