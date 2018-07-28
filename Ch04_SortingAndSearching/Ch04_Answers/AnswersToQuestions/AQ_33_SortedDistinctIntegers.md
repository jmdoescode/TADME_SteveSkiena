4-33. Suppose that you are given a sorted sequence of distinct integers {a1,a2,…,an}. Give an O(lgn) algorithm to determine whether there exists an i index such as ai=i. For example, in {−10,−3,3,5,7}, a3=3. In {2,3,4,5,6,7}, there is no such i.


<details>
<summary>**ANSWER**</summary>
  <p>

	FindIndex(A):  
    1. low =  0, high =1  
    2. mid = (low + high)/2  
    3. if(A[mid] > mid) then  
            Index will lie in left half of the array  
                high = mid-1  
                Go to step 2.  
        else if (A[mid] < mid) then  
            Index will lie in right half of array  
            low = mid + 1  
        else  
            return mid  
  
  </p>
</details>
