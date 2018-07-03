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