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