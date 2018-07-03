4-3. Take a sequence of 2n real numbers as input. Design an O(nlogn) algorithm that partitions the numbers into n pairs, with the property that the partition minimizes the maximum sum of a pair. For example, say we are given the numbers (1,3,5,9). The possible partitions are ((1,3),(5,9)), ((1,5),(3,9)), and ((1,9),(3,5)). The pair sums for these partitions are (4,14), (6,12), and (10,8). Thus the third partition has 10 as its maximum sum, which is the minimum over the three partitions.

<details>
<summary>**ANSWER**</summary>
  <p>

The minimum sum value will be the lowest number and the maximum number. So you must sort and then the value pairs will be those at the following index: 
- increment from index 0 
- decrement from index n - 1 

  </p>
</details>