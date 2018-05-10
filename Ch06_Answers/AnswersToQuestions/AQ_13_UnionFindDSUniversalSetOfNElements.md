6-13. Design a data structure that can perform a sequence of, m union and find operations on a universal set of n elements, consisting of a sequence of all unions followed by a sequence of all finds, in time O(m+n).


<details>
<summary>**ANSWER**</summary>
  <p>

  Union Sequence

  - First create a method that takes in a list of all edges to be unioned. 
  - For each edge in the list call the Find operation from Question 12 passing in the index of start vertex and index of the destination vertex. 

  Find Sequence

  - Next create another method that takes a params array of the index of each component to be found.
  - For each item in the array do the find operation as was mentionded in Question 12. 

  </p>
</details>