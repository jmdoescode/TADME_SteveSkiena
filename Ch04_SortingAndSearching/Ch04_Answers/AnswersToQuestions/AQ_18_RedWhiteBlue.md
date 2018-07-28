4-18. Suppose an array A consists of n elements, each of which is red, white, or blue. We seek to sort the elements so that all the reds come before all the whites, which come before all the blues The only operation permitted on the keys are

Examine(A,i) -- report the color of the ith element of A.  
Swap(A,i,j) -- swap the ith element of A with the jth element.  
Find a correct and efficient algorithm for red-white-blue sorting. There is a linear-time solution. This is also known as the Dutch national flag problem. The simplest linear time solution performs two passes of the partition operation from Quicksort. The first pass treats the red and white elements as indistinguishable, and separates them from the blue. The second pass is just separates the elements within the red/white sub-array.  


<details>
<summary>**ANSWER**</summary>
  <p>

  Iterate through the elements to get count of red, white, and blue elements  
    Index of red = 0 to redCount - 1   
    Index of blue = redcount to (redcount + blue count - 1)  
    Index of white = (redcount + bluecount) to array length - 1  

    iterate through array  
    swap with whatever color it is  
    IF YOU WANT to swap a color but the item is not the correct color  
    Then insert into a queue for each color and once you find a swappable color then swap  
    for example  
        [0]W will swap with B from 0 to 9   
        [1]R will stay   
        [2]B cannot swap with B from 2 to 3  
            Put index 2 into red count queue if index 2 is < redCount (3)  
        [3]B is okay  
        [4]R can switch with index in redCount queue  
        etc...  


    |    R    |           B           |    W    |  
    W - R - B - B - R - B - W - W - R - B - B - W  
    0   1   2   3   4   5   6   7   8   9  10  11  
    											   
    R - R - R - B - B - B - B - B - B - W - W - W  



    Should take O(2n) time  


  </p>
</details>

