4-32. Consider the numerical 20 Questions game. In this game, Player 1 thinks of a number in the range 1 to n. Player 2 has to figure out this number by asking the fewest number of true/false questions. Assume that nobody cheats.

What is an optimal strategy if n is known?      
What is a good strategy if n is not known?  


<details>
<summary>**ANSWER**</summary>
  <p>

	(a)  
        Is the number between 0 to n/2?  
        If yes then as if the number is between the first half  
        If not then ask if the number is between the first half of n/2 to n  
        Repeat recursively  

    (c)  
        If you don't know n start with a random number 2i and if it is larger than the number you are looking for do a binary search within 1−2i as in (1). If 2i is less then guess 2i+1 and repeat.  
  
  </p>
</details>
