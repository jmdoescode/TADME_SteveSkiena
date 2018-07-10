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
</details>---4-7. Outline a reasonable method of solving each of the following problems. Give the order of the worst-case complexity of your methods.

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
</details>---4-8. Given a set of S containing n real numbers, and a real number x. We seek an algorithm to determine whether two elements of S exist whose sum is exactly x.

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
</details>---4-9. Give an efficient algorithm to compute the union of sets A and B, where n=max(|A|,|B|). The output should be an array of distinct elements that form the union of the sets, such that they appear more than once in the union.

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
</details>---4-10. Given a set S of n integers and an integer T, give an O(n^(k−1) logn) algorithm to test whether k of the integers in S add up to T. 

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
</details>---4-11. Design an O(n) algorithm that, given a list of n elements, finds all the elements that appear more than n/2 times in the list. Then, design an O(n) algorithm that, given a list of n elements, finds all the elements that appear more than n/4 times.

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
</details>---4-12. Devise an algorithm for finding the k smallest elements of an unsorted set of n integers in O(n+klogn).

<details>
<summary>**ANSWER**</summary>
  <p>

Scan through the array to build an out-of-order heap, that is, the first element is indeed the smallest, but necessarily any of the other elements. This takes us O(n).  
Then extract from the heap k times to get the smallest k elements using O(klogn).  
Thus the total time is O(n+klogn).  

  </p>
</details>---4-13. You wish to store a set of n numbers in either a max-heap or a sorted array. For each application below, state which data structure is better, or if it does not matter. Explain your answers.

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
</details>---