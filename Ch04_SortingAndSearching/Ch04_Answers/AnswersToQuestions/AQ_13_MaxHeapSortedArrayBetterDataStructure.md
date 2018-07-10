4-13. You wish to store a set of n numbers in either a max-heap or a sorted array. For each application below, state which data structure is better, or if it does not matter. Explain your answers.

a) Want to find the maximum element quickly.  
b) Want to be able to delete an element quickly.  
c) Want to be able to form the structure quickly.  
d) Want to find the minimum element quickly.  


<details>
<summary>**ANSWER**</summary>
  <p>

a) Both. Max-heap will have max at the top and sorted array will have max at the end.

b) max heap - costs O(log n)  
&nbsp;&nbsp;&nbsp; sorted array - costs O(n) to update all elements

c) max-heap - O(n)  
&nbsp;&nbsp;&nbsp; sorted array - O(n log n)

d) max-heap - O(n)  
&nbsp;&nbsp;&nbsp; sorted array - O(1)

  </p>
</details>