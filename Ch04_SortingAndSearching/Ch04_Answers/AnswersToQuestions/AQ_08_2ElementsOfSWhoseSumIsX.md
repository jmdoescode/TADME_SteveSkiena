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