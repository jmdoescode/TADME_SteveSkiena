4-1. The Grinch is given the job of partitioning 2n players into two teams of n players each. Each player has a numerical rating that measures how good he/she is at the game. He seeks to divide the players as unfairly as possible, so as to create the biggest possible talent imbalance between team A and team B. Show how the Grinch can do the job in O(nlogn) time. 


<details>
<summary>**ANSWER**</summary>
  <p>

Do a quick sort then choose the bottom half as team 1 and top half as team 2 or choose the first and middle player and increment both at the same time complexity 

  </p>
</details>