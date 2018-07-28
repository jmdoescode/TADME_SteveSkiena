4-20. Give an efficient algorithm to rearrange an array of n keys so that all the negative keys precede all the nonnegative keys. Your algorithm must be in-place, meaning you cannot allocate another array to temporarily hold the items. How fast is your algorithm?


<details>
<summary>**ANSWER**</summary>
  <p>

	If order does not matter  
    Iterate once to get the number of negative numbers  
    The count will be the Pivot  
    Left pointer starts at 0  
    Right pointer starts at array Length - 1  
    increment index of pointers and when left pointer is nonnegative and right pointer is negative then swap  
    repeat until one of the pointers hits the pivot  

    worst run time is O(2n) -> O(n)



    ---------------------------------------------------------

    If you partition the array with pivoting 0, all negative values appear before all other positive values. This can be done in linear time, O(n).
  
  </p>
</details>
