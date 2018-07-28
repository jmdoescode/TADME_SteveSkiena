4-43. You have a computer with only 2Mb of main memory. How do you use it to sort a large file of 500 Mb that is on disk?


<details>
<summary>**ANSWER**</summary>
  <p>

	Sort the first 2MB of it, and save to disk. Continue doing so until it is all sorted into sub arrays. Then use merge sort to combine sub arrays, only loading necessary data into memory.
  
  </p>
</details>
