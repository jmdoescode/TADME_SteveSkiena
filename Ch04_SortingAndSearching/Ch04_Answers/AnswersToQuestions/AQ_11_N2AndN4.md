4-11. Design an O(n) algorithm that, given a list of n elements, finds all the elements that appear more than n/2 times in the list. Then, design an O(n) algorithm that, given a list of n elements, finds all the elements that appear more than n/4 times.

<details>
<summary>**ANSWER**</summary>
  <p>

if not sorted and for n/4  
iterate putting each value into a dictionary increment the count if it does not exist  
&nbsp;&nbsp;&nbsp; if it already exists in the dictionary increment count  
&nbsp;&nbsp;&nbsp; if count > n/2 return key (it can only occur one time)  
&nbsp;&nbsp;&nbsp; at the end iterate through dictionary where value > n/4 times  
&nbsp;&nbsp;&nbsp; third value of dictionary > n/2 is last value and you can stop  

  </p>
</details>