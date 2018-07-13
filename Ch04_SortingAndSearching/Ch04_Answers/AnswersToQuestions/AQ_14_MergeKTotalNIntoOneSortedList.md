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
