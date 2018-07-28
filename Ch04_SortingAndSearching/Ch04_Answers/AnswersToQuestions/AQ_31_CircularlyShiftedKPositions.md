4-31. Suppose you are given an array A of n sorted numbers that has been circularly shifted k positions to the right. For example, {35,42,5,15,27,29} is a sorted array that has been circularly shifted k=2 positions, while {27,29,35,42,5,15} has been shifted k=4 positions.

Suppose you know what k is. Give an O(1) algorithm to find the largest number in A.
Suppose you do not know what k is. Give an O(lgn) algorithm to find the largest number in A. For partial credit, you may give an O(n) algorithm.


<details>
<summary>**ANSWER**</summary>
  <p>

	(a)  
        k - 1 index is largest  

    (b) 
        Find halfway point  
        Whichever number is larest at beginning of each halfway then look inside that one  
        Repeat until you have the largest number  

    ---------------------------------------------------------------

    (b)  
        Assume set indexes are zero based  
        FindNumberOfRotations(A):  
            1. if  (A[0] < A[n-1]) then  
                There is no rotation made return 0  
            2. low =  0, high =1  
            3. mid = (low + high)/2  
            4. if(A[mid] < A[high]) then  
                    Transition lies in left half of the array  
                    if A[mid-1] > A[mid] then return mid  
                    else  
                        high = mid-1  
                        Go to step 3.  
                else  
                    Transition lies in right half of array  
                    if(A[mid] > A[mid+1]) then return mid+1  
                    else  
                        low = mid+1  
                        Go to step 3  

  
  </p>
</details>
