4-1. The Grinch is given the job of partitioning 2n players into two teams of n players each. Each player has a numerical rating that measures how good he/she is at the game. He seeks to divide the players as unfairly as possible, so as to create the biggest possible talent imbalance between team A and team B. Show how the Grinch can do the job in O(nlogn) time. 


<details>
<summary>**ANSWER**</summary>
  <p>

Do a quick sort then choose the bottom half as team 1 and top half as team 2 or choose the first and middle player and increment both at the same time complexity 

  </p>
</details>


---


4-2. For each of the following problems, give an algorithm that finds the desired numbers within the given amount of time. To keep your answers brief, feel free to use algorithms from the book as subroutines. For the example, S={6,13,19,3,8}, 19−3 maximizes the difference, while 8−6 minimizes the difference. 

(a) Let S be an unsorted array of n integers. Give an algorithm that finds the pair x,y∈S that maximizes |x−y|. Your algorithm must run in O(n) worst-case time. 

(b) Let S be a sorted array of n integers. Give an algorithm that finds the pair x,y∈S that maximizes |x−y|. Your algorithm must run in O(1) worst-case time. 

(c) Let S be an unsorted array of n integers. Give an algorithm that finds the pair x,y∈S that minimizes |x−y|, for x≠y. Your algorithm must run in O(nlogn) worst-case time. 

(d) Let S be a sorted array of n integers. Give an algorithm that finds the pair x,y∈S that minimizes |x−y|, for x≠y. Your algorithm must run in O(n) worst-case time.

<details>
<summary>**ANSWER**</summary>
  <p>

(a) Iterate through the array keeping a |min| and |max| variables and subtract at the end

(b) You need to get S[0] and S[n-1]

(c) Sort the array with any nlog(n) method. Then scan through the sorted array to find the smallest gap, thus the desired pair.
You can also do this in O(2n) time. Iterate through array once to get the minimum as minimum1. Then iterate through again to get the minimum2 that is greater than minimum1.

(d) Get S[n-1] and S[n-2] if the sort is descending. 

  </p>
</details>


---


4-3. Take a sequence of 2n real numbers as input. Design an O(nlogn) algorithm that partitions the numbers into n pairs, with the property that the partition minimizes the maximum sum of a pair. For example, say we are given the numbers (1,3,5,9). The possible partitions are ((1,3),(5,9)), ((1,5),(3,9)), and ((1,9),(3,5)). The pair sums for these partitions are (4,14), (6,12), and (10,8). Thus the third partition has 10 as its maximum sum, which is the minimum over the three partitions.

<details>
<summary>**ANSWER**</summary>
  <p>

The minimum sum value will be the lowest number and the maximum number. So you must sort and then the value pairs will be those at the following index: 
- increment from index 0 
- decrement from index n - 1 

  </p>
</details>



---



4-4. Assume that we are given n pairs of items as input, where the first item is a number and the second item is one of three colors (red, blue, or yellow). Further assume that the items are sorted by number. Give an O(n) algorithm to sort the items by color (all reds before all blues before all yellows) such that the numbers for identical colors stay sorted. For example: (1,blue), (3,red), (4,blue), (6,yellow), (9,red) should become (3,red), (9,red), (1,blue), (4,blue), (6,yellow).

<details>
<summary>**ANSWER**</summary>
  <p>

- Make 3 lists (or buckets) - each corresponding to a color
- Iterate through one time
- For each pair put into the corresponding list 
- Then quicksort each bucket for the number  
- Display all in this order: reds, blues, and yellows 

  </p>
</details>



---


4-5. The mode of a set of numbers is the number that occurs most frequently in the set.The set (4, 6, 2, 4, 3, 1) has a mode of 4. Give an efficient and correct algorithm to compute the mode of a set of n numbers.


<details>
<summary>**ANSWER**</summary>
  <p>

Iterate through array and create a dictionary  
int max; int maxCount;  
For each value  
&nbsp;&nbsp;&nbsp;&nbsp; Insert into dictionary with value being the key  
&nbsp;&nbsp;&nbsp;&nbsp; increment the count of that value  
&nbsp;&nbsp;&nbsp;&nbsp; if value of key in dictionary > maxCount          
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; change max   
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; change maxCount  

return the max


  </p>
</details>




---


4.6 Given two sets S1 and S2(each of size n), and a number x, describe an O(n log n) algorithm for finding whether there exists a pair of elements, one from S1 and one from S2, that add up to x. (For partial credit, give a Θ(n2) algorithm for this problem.)


<details>
<summary>**ANSWER**</summary>
  <p>

1. Sort S1; O(n log n)
2. for i=0 to n-1  
    val = x - S2[i]  
    if binary_search(S1, val) O(log n)  
	&nbsp;&nbsp;&nbsp;&nbsp;return (val, S2[i])  
End Loop

  </p>
</details>




---


4-7. Outline a reasonable method of solving each of the following problems. Give the order of the worst-case complexity of your methods.

a) You are given a pile of thousands of telephone bills and thousands of checks sent in to pay the bills. Find out who did not pay.

b) You are given a list containing the title, author, call number and publisher of all the books in a school library and another list of 30 publishers. Find out how many of the books in the library were published by each company.
    
c) You are given all the book checkout cards used in the campus library during the past year, each of which contains the name of the person who took out the book. Determine how many distinct people checked out at least one book.


<details>
<summary>**ANSWER**</summary>
  <p>

a) Iterate telephone bills and insert each value into a Dictionary with name as the key.
	Iterate checks and find Dictionary KVP with same name and if value of check is >= bill then delete bucket.
    Use address as tie breaker for same names.
	The Keys you have at the end are those who did not pay.
	O(n + m) = O(n).

b) Each publisher is its own Dictionary KVP.
	Iterate books and increment count of corresponding bucket.
	Iterate through KVP and get value for each key.
	O(n*30) = O(n)

c) Create a HashSet with all the names.
	Iterate through all book checkout cards adding name if it doesn't exist.
	Did not use a list here because HashSets are better at finding a value than lists. Lists will have to iterate from first to last to find the key while dictionaries us individual buckets.

  </p>
</details>


---


4-8. Given a set of S containing n real numbers, and a real number x. We seek an algorithm to determine whether two elements of S exist whose sum is exactly x.

a) Assume that S is unsorted. Give an O(nlogn) algorithm for the problem.
   
b) Assume that S is sorted. Give an O(n) algorithm for the problem.


<details>
<summary>**ANSWER**</summary>
  <p>

(a)Sort S with any nlogn sorting method of your choice.

    for( int i = 1; i <= n; ++i )
    {
        int j = x - S[i];
        Binary search for j in the sub-array of S[i+1~n] and close the problem once it's been found;
    }
    
(b)Subtract each of S[1~n] from x to get a new array of real numbers T[1~n].  
T(must be sorted ascending)

    int i = 1, j = 1;
    while( i <=n && j <= n )
    {
        if( S[i] == T[j] )
        {
            problem solved;
            break;
        }
        else
        {
            S[i] < T[j] ? ++i : ++j;
        }
    }


Solution 2

    i = 0;
    j = n - 1;

    for (i = 0; i < j; i++)
    {
        while( (i < j) && (S[j] + S[i] > x ) ) 
        { j--;
        }
        if (x == (S[j] + S[i]) )
        {
        return true;
   
        }
    }

    "i" scans from left to right, "j" from right to left,
    looking for the right pair...

  </p>
</details>



---


4-9. Give an efficient algorithm to compute the union of sets A and B, where n=max(|A|,|B|). The output should be an array of distinct elements that form the union of the sets, such that they appear more than once in the union.

a) Assume that A and B are unsorted. Give an O(nlogn) algorithm for the problem.

b) Assume that A and B are sorted. Give an O(n) algorithm for the problem.


<details>
<summary>**ANSWER**</summary>
  <p>

a) Sort the sets (which takes O(nlogn)) and use the algorithm described in 2) which takes O(n) (which is also O(nlogn)).

b) A and B are sorted (assume in ascending order). The fact that the sets are sorted implies that there is a comparison defined on the elements of A and B (i.e. we can tell whether an element is greater, equal to or smaller than another element).

    let U be the set which will contain the union
    while A and B are not empty:
    if the first element of A is equal to the last element added to U, remove the first element of A and continue with the next iteration.
    if the first element of B is equal to the last element added to U, remove the first element of B and continue with the next iteration.
    if the first (lowest) element of A is strictly smaller than the first (lowest) element of B, remove the first element of A and add it to U, then continue with the next iteration.
    if the first (lowest) element of A is strictly greater than the first (lowest) element of B, remove the first element of B and add it to U, then continue with the next iteration.
    if the first (lowest) element of A is equal to the first (lowest) element of B, remove the first element from each A and B and add one of them to U, then continue with the next iteration.
    After the while loop, either A or B or both are empty. If one of them is non-empty, add its elements to U.


  </p>
</details>


---


4-10. Given a set S of n integers and an integer T, give an O(n^(k−1) logn) algorithm to test whether k of the integers in S add up to T. 

<details>
<summary>**ANSWER**</summary>
  <p>

If unsorted sort first.  
Find the value of T with binary search.  
This will be your upper bound.  
Subtract first from T.  
&nbsp;&nbsp;&nbsp;&nbsp;Binary Search for that difference.  

and repeat 


  </p>
</details>


---


4-11. Design an O(n) algorithm that, given a list of n elements, finds all the elements that appear more than n/2 times in the list. Then, design an O(n) algorithm that, given a list of n elements, finds all the elements that appear more than n/4 times.

<details>
<summary>**ANSWER**</summary>
  <p>

if not sorted and for n/4  
iterate putting each value into a dictionary increment the count if it does not exist  
&nbsp;&nbsp;&nbsp; if it already exists in the dictionary increment count  
&nbsp;&nbsp;&nbsp; if count > n/2 return key (it can only occur one time)  
&nbsp;&nbsp;&nbsp; at the end iterate through dictionary where value > n/4 times  
&nbsp;&nbsp;&nbsp; third value of dictionary > n/2 is last value and you can stop  

  </p>
</details>



---


4-12. Devise an algorithm for finding the k smallest elements of an unsorted set of n integers in O(n+klogn).

<details>
<summary>**ANSWER**</summary>
  <p>

Scan through the array to build an out-of-order heap, that is, the first element is indeed the smallest, but necessarily any of the other elements. This takes us O(n).  
Then extract from the heap k times to get the smallest k elements using O(klogn).  
Thus the total time is O(n+klogn).  

  </p>
</details>


---


4-13. You wish to store a set of n numbers in either a max-heap or a sorted array. For each application below, state which data structure is better, or if it does not matter. Explain your answers.

a) Want to find the maximum element quickly.  
b) Want to be able to delete an element quickly.  
c) Want to be able to form the structure quickly.  
d) Want to find the minimum element quickly.  


<details>
<summary>**ANSWER**</summary>
  <p>

a) Both. Max-heap will have max at the top and sorted array will have max at the end.

b) max heap - costs O(log n)  
&nbsp;&nbsp;&nbsp; sorted array - costs O(n) to update all elements

c) max-heap - O(n)  
&nbsp;&nbsp;&nbsp; sorted array - O(n log n)

d) max-heap - O(n)  
&nbsp;&nbsp;&nbsp; sorted array - O(1)

  </p>
</details>



---


4-14. Give an O(nlogk)-time algorithm that merges k sorted lists with a total of n elements into one sorted list. (Hint: use a heap to speed up the elementary O(kn)-time algorithm).

<details>
<summary>**ANSWER**</summary>
  <p>

Iterate through k sorted lists getting minimum value of each one and updating the min value  
When you upate the min value save the list and update that index and subtract index of last one if it has been updated  
Then insert that value into a new list  

---

Scan through all k lists in any order and use the stream of elements to build a heap of k elements. Since bubble_down works in O(logk) for a heap of k elements, we thus solve the problem in O(nlogk).

The elementary algorithm compares the heads of each of the k sorted lists to find the minimum element, 
puts this in the sorted list and repeats.  
The total time is O(kn).  
Suppose instead that we build a heap on the head elements of each of the k lists, with each element labeled as to which list it is from.  
The minimum element can be found and deleted in O(logk) time.  
Further, we can insert the new head of this list in the heap in O(logk) time.  
An alternate O(nlogk) approach would be to merge the lists from as in mergesort, using a binary tree on k leaves (one for each list)

  </p>
</details>



---


4-15. (a) Give an efficient algorithm to find the second-largest key among n keys. You can do better than 2n−3 comparisons. (b) Then, give an efficient algorithm to find the third-largest key among n keys. How many key comparisons does your algorithm do in the worst case? Must your algorithm determine which key is largest and second-largest in the process?


<details>
<summary>**ANSWER**</summary>
  <p>

1) You could max heapify the entire array of keys which takes O(n) time and then the elements below are either the second or third largest and you just compare those two.

2) You can scan through the array of keys keeping max1, max2, and max3 variables and comparing them against the newest key.

  </p>
</details>



---


4-16. Use the partitioning idea of quicksort to give an algorithm that finds the median element of an array of n integers in expected O(n) time. (Hint: must you look at both sides of the partition?)


<details>
<summary>**ANSWER**</summary>
  <p>

  the general form of this problem is to find the kth largest value. finding the median is when k = n/2.  

    to find the kth largest value,

    select a partition element and split the array into 2 sub-arrays - one with the elements smaller than the partition and one with the elements larger than the partition. O(n)

    if the array with the elements larger than the partition has k - 1 elements, the partition is the kth largest element  
    if the array with the elements larger than the partition has >= k elements, recurse with the same value of k using the larger elements as the new array. O(n/2) (average case)  
    else the median is in the array with elements smaller than the partition so adjust k to account for the large elements being discarded and recurse using the smaller elements as the new array O(n/2) (average case)  
    the overall complexity is O(n) since  

    O(n) + O(n/2) + O(n/4) + ... approaches O(2n) which is just O(n) since 2 is a constant.


    https://andonov.wordpress.com/2013/02/17/finding-the-largest-elements-in-an-array/

  </p>
</details>



---


4-17. The median of a set of n values is the ⌈n/2⌉th smallest value.

Suppose quicksort always pivoted on the median of the current sub-array. How many comparisons would Quicksort make then in the worst case?  
Suppose quicksort were always to pivot on the ⌈n/3⌉th smallest value of the current sub-array. How many comparisons would be made then in the worst case?  


<details>
<summary>**ANSWER**</summary>
  <p>

    (a)  
        half

    (b)  
        Let F(n) be the number of compares for a quicksort of size n, split into a section of size 1/3 and a section of size 2/3. The recurrence relation would be:

        F(n) = n/3 + 2n/3 + F(n/3) + F(2n/3) = n + F(n/3) + F(2n/3)

        In other words, the number of compares at size n is equal to the number of compares to do a top level partition (1/3 for one side, 2/3 for the other side), plus the number of compares to quicksort the 1/3 partition and the 2/3 partition.

  </p>
</details>


---


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


---


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



---


4-20. Give an efficient algorithm to rearrange an array of n keys so that all the negative keys precede all the nonnegative keys. Your algorithm must be in-place, meaning you cannot allocate another array to temporarily hold the items. How fast is your algorithm?


<details>
<summary>**ANSWER**</summary>
  <p>

	If order does not matter  
    Iterate once to get the number of negative numbers  
    The count will be the Pivot  
    Left pointer starts at 0  
    Right pointer starts at array Length - 1  
    increment index of pointers and when left pointer is nonnegative and right pointer is negative then swap  
    repeat until one of the pointers hits the pivot  

    worst run time is O(2n) -> O(n)



    ---------------------------------------------------------

    If you partition the array with pivoting 0, all negative values appear before all other positive values. This can be done in linear time, O(n).
  
  </p>
</details>



---


4-21. Stable sorting algorithms leave equal-key items in the same relative order as in the original permutation. Explain what must be done to ensure that mergesort is a stable sorting algorithm.


<details>
<summary>**ANSWER**</summary>
  <p>

    The one you're merging on the left goes first (lower indexed value of the tie will go first)

    ---------------------------------------------------

    To guarantee mergesort is stable, when merging the two subarrays together, mergesort should settle ties in the lists by choosing the lower indexed value.
  
  </p>
</details>



---


4-22. Show that n positive integers in the range 1 to k can be sorted in O(nlogk) time. The interesting case is when k<<n.


<details>
<summary>**ANSWER**</summary>
  <p>

    Since we want O(logn) time, we could consider using a heap.  
    Inserting each value in the 1 - k range takes O(logk) time.  
    Afterwards, we can do a walk of the heap and successively retrieve the items in order.  
    Takes O(nlogk) time in total.  

    The heap values can hold the occurence count of each value in some extra memory storage.
    
  
  </p>
</details>



---


4-23. We seek to sort a sequence S of n integers with many duplications, such that the number of distinct integers in S is O(logn). Give an O(nloglogn) worst-case time algorithm to sort such sequences.


<details>
<summary>**ANSWER**</summary>
  <p>

	With a self-balancing binary search tree, we can achieve O(log k) search and insertion (where k is the number of elements in the tree).
    
    1. For each element in the sequence S, try and insert it into the tree.  
    - If the element is present, we increment a count variable stored at a node.  
    - If the element is not present, we insert the node and set the count = 1.  

    2. Traverse the tree in order and add elements according to the count.

    Since the tree is guaranteed not to exceed log n elements, search and insertion take O(log log n).  
    Thus, this entire algorithm takes O(n * log log n + log n) = O(n * log log n) as required.  

  
  </p>
</details>



---


4-24. Let A[1..n] be an array such that the first n−n√ elements are already sorted (though we know nothing about the remaining elements). Give an algorithm that sorts A in substantially better than nlogn steps.


<details>
<summary>**ANSWER**</summary>
  <p>

	The remaining √n unsorted elements can be sorted in O(√nlogn) time. Both sorted halves can be merged in O(n) time giving a total run time of *O(n) + O(√nlogn) which is dominated by O(n).

  
  </p>
</details>



---


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



---


4-26. Consider the problem of sorting a sequence of n 0's and 1's using comparisons. For each comparison of two values x and y, the algorithm learns which of x<y, x=y, or x>y holds.

Give an algorithm to sort in n−1 comparisons in the worst case. Show that your algorithm is optimal.  
Give an algorithm to sort in 2n/3 comparisons in the average case (assuming each of the n inputs is 0 or 1 with equal probability). Show that your algorithm is optimal.  


<details>
<summary>**ANSWER**</summary>
  <p>

	Choose a random pivot, it will either be 0 or 1; then do the remaining comparisions around it.  
    Worst case is n-1 comparisions needed.
  
  </p>
</details>



---


4-27. Let P be a simple, but not necessarily convex, polygon and q an arbitrary point not necessarily in P. Design an efficient algorithm to find a line segment originating from q that intersects the maximum number of edges of P. In other words, if standing at point q, in what direction should you aim a gun so the bullet will go through the largest number of walls. A bullet through a vertex of P gets credit for only one wall. An O(nlogn) algorithm is possible.



<details>
<summary>**ANSWER**</summary>
  <p>

	Since a bullet through a vertex doesn't count as 2 walls, let's describe the polygon P in terms of pairs of points like [(x0,y1),(x2,y2)). That is, the first point will count as a wall, but the second will not.

    Next, let's convert all of the points in P to polar notation. We don't actually need to store the radius, however, just the angle θ. Also, the polar notation is relative to q's location, (qx,qy), so for every point p in P we have θp=atan((py−qy)/(px−qx)). These calculations are done on every point, so a computational complexity of Θ(n).

    Keep a list of the line segments, with points stored as pairs of angles relative to q, and sort them by the minimum of the two angles. It is okay to switch which angle comes first in a pair, but the pairs must move together when they are sorted. It is also important to preserve knowledge of which point was the source (closed interval) and which was the destination (open interval), so we don't count one vertex twice. This sorting costs O(n lg n), and it is the dominant factor in this algorithm.[ 

    Finally, iterate through the sorted list of minimum elements, incrementing a counter whenever the start of a line segment is encountered, and decrementing the counter whenever a line segment ends.


  
  </p>
</details>



---


4-28. sorting algorithm that runs in O(nlog(n√)). Given the existence of an Ω(nlogn) lower bound for sorting, how can this be possible? lower bound


<details>
<summary>**ANSWER**</summary>
  <p>


  
  </p>
</details>



---


4-29. Mr. B. C. Dull claims to have developed a new data structure for priority queues that supports the operations Insert, Maximum, and Extract-Max---all in O(1) worst-case time. Prove that he is mistaken. (Hint: the argument does not involve a lot of gory details---just think about what this would imply about the Ω(nlogn) lower bound for sorting.)


<details>
<summary>**ANSWER**</summary>
  <p>

    If this claim was true one could construct a linear time sorting algorithm by inserting all elements and then extracting all maximum elements again. Since the lower bound of O(n log n) for searching this is not possible.
  
  </p>
</details>



---


4-30. A company database consists of 10,000 sorted names, 40% of whom are known as good customers and who together account for 60% of the accesses to the database. There are two data structure options to consider for representing the database:

Put all the names in a single array and use binary search.
Put the good customers in one array and the rest of them in a second array.
Only if we do not find the query name on a binary search of the first array do we do a binary search of the second array. Demonstrate which option gives better expected performance. Does this change if linear search on an unsorted array is used instead of binary search for both options?


<details>
<summary>**ANSWER**</summary>
  <p>

    Option 1 is preferred since using binary search would require a maximum of log10000 ~ 13 in the worst case as opposed to log4000 + log6000 ~ 11 + 12 for the split scenario.

    For linear search, option 2 would be preferred as most times, searching the 4000 customers would return the desired result and if the search extends to 6000, the worst case scenario is still 10000 just like option 1.

  
  </p>
</details>



---


