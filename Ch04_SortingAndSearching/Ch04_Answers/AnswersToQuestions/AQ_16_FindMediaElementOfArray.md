4-16. Use the partitioning idea of quicksort to give an algorithm that finds the median element of an array of n integers in expected O(n) time. (Hint: must you look at both sides of the partition?)


<details>
<summary>**ANSWER**</summary>
  <p>

  the general form of this problem is to find the kth largest value. finding the median is when k = n/2.  

    to find the kth largest value,

    select a partition element and split the array into 2 sub-arrays - one with the elements smaller than the partition and one with the elements larger than the partition. O(n)

    if the array with the elements larger than the partition has k - 1 elements, the partition is the kth largest element  
    if the array with the elements larger than the partition has >= k elements, recurse with the same value of k using the larger elements as the new array. O(n/2) (average case)  
    else the median is in the array with elements smaller than the partition so adjust k to account for the large elements being discarded and recurse using the smaller elements as the new array O(n/2) (average case)  
    the overall complexity is O(n) since  

    O(n) + O(n/2) + O(n/4) + ... approaches O(2n) which is just O(n) since 2 is a constant.


    https://andonov.wordpress.com/2013/02/17/finding-the-largest-elements-in-an-array/

  </p>
</details>