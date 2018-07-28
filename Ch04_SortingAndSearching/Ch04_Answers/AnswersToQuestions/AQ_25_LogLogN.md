4-25. Assume that the array A[1..n] only has numbers from {1,…,n^2} but that at most loglogn of these numbers ever appear. Devise an algorithm that sorts A in substantially less than O(nlogn).


<details>
<summary>**ANSWER**</summary>
  <p>

	
    Just as a reminder as of how slowly the log(log(n)) function grows:

        n	    log(log(n))  
        10	    0.83  
        100	    1.53  
        1000	1.93  
        10000	2.22  

        The array will therefore consist of only very few distinct numbers and all others will be repetitions. An idea to sort such an array is the following


        First sweep through the original array and create two auxiliary arrays of numbers A′={a′1,a′2,a′3,…} (with ∃ i,j:ai=aj) and their repetition count N={n1,n2,n3,…} : this can be done in O(n) time  
        Then sort the two arrays in parallel, comparing keys from A′ : this can be done in O(x log(x)) time with x=log(log(n))  
        Finally recreate a sorted version of the original array by taking every number a′i and repeat it ni times : this can again be done in O(n) time  

  
  </p>
</details>
