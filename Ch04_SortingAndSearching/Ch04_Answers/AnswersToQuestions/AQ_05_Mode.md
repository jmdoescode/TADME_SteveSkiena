4-5. The mode of a set of numbers is the number that occurs most frequently in the set.The set (4, 6, 2, 4, 3, 1) has a mode of 4. Give an efficient and correct algorithm to compute the mode of a set of n numbers.


<details>
<summary>**ANSWER**</summary>
  <p>

Iterate through array and create a dictionary
int max; int maxCount;
For each value
    Insert into dictionary with value being the key
    increment the count of that value
    if value of key in dictionary > maxCount        
        change max 
        change maxCount

return the max


  </p>
</details>
