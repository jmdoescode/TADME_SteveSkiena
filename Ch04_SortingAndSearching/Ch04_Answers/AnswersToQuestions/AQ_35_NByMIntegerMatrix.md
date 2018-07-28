4-35. Let M be an n×m integer matrix in which the entries of each row are sorted in increasing order (from left to right) and the entries in each column are in increasing order (from top to bottom). Give an efficient algorithm to find the position of an integer x in M, or to determine that x is not there. How many comparisons of x with matrix entries does your algorithm use in worst case?


<details>
<summary>**ANSWER**</summary>
  <p>

	Binary Search n to find if x is or lies inbetween indexOfN and indexOfN + 1  
    and then do the same for m

    --------------------------------------------------

    Point* findPosition(int key) {  
     int row = 0, col = m-1;  
     while (row < n && col >= 0) {  
        if (M[row][col] == key) {  
           return new Point(row,col);           
        }  
        else if (M[row][col] > key) {  
           col--;  
        }  
        else row++;   
     }  
     return NULL;  
   }  
  
  </p>
</details>
