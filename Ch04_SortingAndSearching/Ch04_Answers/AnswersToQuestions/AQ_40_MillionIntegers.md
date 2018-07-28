4-40. If you are given a million integers to sort, what algorithm would you use to sort them? How much time and memory would that consume?


<details>
<summary>**ANSWER**</summary>
  <p>

	QuickSort


    -----------------------------

    For a known set of integer numbers ( assume Nr-1, Nr-2 ... Nr-k) the best is to use a non-comparison based sort algorithm like radix sort with O(n)

    You have an array that creates a histogram of all numbers ( histoThenStartIndexArray[Nr-i]++)

    Step 2, in the same array calculate the index of that position For example if there are 3 numbers 99, and 5 numbers 105, the next index will be 8 for the next number

    Step 3, parse array and display values
  
  </p>
</details>
