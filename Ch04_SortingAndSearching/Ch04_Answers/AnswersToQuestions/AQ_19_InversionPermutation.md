4-19. An inversion of a permutation is a pair of elements that are out of order.

Show that a permutation of n items has at most n(n−1)/2 inversions. Which permutation(s) have exactly n(n−1)/2 inversions?  
Let P be a permutation and Pr be the reversal of this permutation. Show that P and Pr have a total of exactly n(n−1)/2 inversions.  
Use the previous result to argue that the expected number of inversions in a random permutation is n(n−1)/4.  


<details>
<summary>**ANSWER**</summary>
  <p>

1) Starting from left to right, the number of inversions

     for 1st number is n-1  
     for 2nd number is n-2  
     ...  
     ..  
     ....nth number is n-n = 0  
    Total number of inversions is the sum of all of the above sum of integers from 0 to n - 1 = n(n-1)/2

2. We know that the maximum num of inversions is n(n-1)/2.

     Consider a permutation P.  
     a1 a2 ai..ak...aj..am.... an-1 an  
     ai and aj are out of order  
     ak and am are in order.   
     For Pr,  
     ai and aj will get reversed, and will become in order.  
     ak and am will get reversed and will become out of order.  
     Every In order pair becomes an inversion.  
     And every inversion becomes corrected.  
  
    If P contains "x" inversions.. then it also contained "n(n-1)/2 - x" in order pairs. Thus Pr contains "x" in order pairs and "n(n-1)/2 - x" inversions.

    Summing up the inversions in P and Pr we get n(n-1)/2

3. To calculate the max inversions in part 1, every ith position had n - i inversions. i.e following a number, all other numbers will be out of order. In the average case, we can argue that about 1/2 of the number will be out of order....

     for 1st number  (n-1)/2  
     for 2nd number   (n-2)/2  
     ...  
     ..  
     ....nth number is (n-n)/2 = 0  
  
  </p>
</details>
