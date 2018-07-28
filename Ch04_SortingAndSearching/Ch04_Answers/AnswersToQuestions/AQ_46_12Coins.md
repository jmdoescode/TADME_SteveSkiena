4-46. You are given 12 coins. One of them is heavier or lighter than the rest. Identify this coin in just three weighings.

Note - weighings are with a balance, where you can have a greater than, equal to, or less than result. You can't do this with a digital scale.


<details>
<summary>**ANSWER**</summary>
  <p>

	My Solution https://www.youtube.com/watch?v=iYtSH5wWh_w  
    Divide into 3 sets of 4 elements  
    Number them  

    STEP 1  
        Weigh 1-2-3-4 and 5-6-7-8  

    STEP 2  
        IF unbalanced, then we know that 9-10-11-12 are good   
        9-10-11-12 will be marked as B for balanced  
        H will be heavy  
        and L will be Light  

        Take 3 from the lighter side and put it into the other side and keep one of lighter there  
        and replace 3 from the lighter side with the good balanced ones  
        Now you have  
            from  
            2H - 2H - 2H - 2H  ---  2L - 2L - 2L - 2L   //////   B - B  - B  - B  

            2H - 2L - 2L - 2L  ---  2L - B  - B  - B    //////   B - 2H - 2H - 2H  

                
            IF they are now balanced then one of the 2H on the right side is the culprit  
                We assume 2 of the three 2H is balanced  
                STEP 3  
                    If they are the same weight then the one not weighed is the culprit  
                    If they are NOT the same weight then the heavier one is the culprit since we know it came from the heavy side  
                
            IF The left side is heavier than the odd ball is either 2H on the left or 2L on the right  
                STEP 3  
                    Weigh one of them against a green  
                        IF balanced then the one not weighed is it  
                        IF unbalanced then the coin that is not a balanced coin is  

            IF the right side is heavier then it means the odd ball is one of the 1L on the left side                 
                We assume 2 of the three 1L is balanced  
                STEP 3  
                    If they are the same the the one not weighed is the culprit  
                    IF they are NOT the same weight then the lighter of the 2 is the culprit since we know they came from the lighter side  

            
                
    STEP 2  
        IF it is balance then it is in 9-10-11-12    
        Weight 9-10-11 against Any of the balanced ones    

            9 - 10 - 11  --- B - B - B  

            IF They are the same then 12 is the culprit  

            IF the left side is heavier we know that the coin is heavy on the left side  
                STEP 3    
                    compare any 2 of the 3 remaining   
                    IF balanced then odd ball is heavier  
                    Otherwise the heavier one is it  

            IF the left side if Lighter we know the coin is light on the left side  
                STEP 3  
                    compare any 2 of the 3 remaining   
                    IF balanced then odd ball is lighter  
                    Otherwise the lighter one is it  









    -------------------------------------------------------

    Solution: Number the coins 1 through 12 and divide them coins into 4 sets of 3...  

    There are multiple comparison sets possible. This is an acceptable template to find a few of them. (This template is NOT definitive, there are other solutions that don't follow this template)  

    Compare   (set 1 & 1st coin from set 4)  against  (set 2 + 2nd coin from set 4)  
    Compare   (set 1 & 2nd coin from set 4)  against  (set 3 + 1st coin from set 4)  
    Compare   (1st coin from each set)       against  (3rd coin from each set)  
    A more concise example:  

    Compare   1 2 3 10  against  4 5 6 11
    Compare   1 2 3 11  against  7 8 9 10
    Compare   1 4 7 10  against  3 6 9 12
    Each weighing can have 3 possible outcomes: Left Heavy, Right Heavy, or Balanced (L,R or B)  

    Build a truth table to interpret outcomes...many outcomes are not possible. Note: THE TABLE VALUES ARE DERIVED FROM THE CHOSEN COMPARISON SETS!

    outcome:    fake coin:    
    l l l       1 is heavy	  
    r r r       1 is light	  
    l l b       2 is heavy	  
    r r b       2 is light	  
    l l r       3 is heavy	  
    r r l       3 is light	  
    r b l       4 is heavy	  
    l b r       4 is light	  
    r b b       5 is heavy	  
    l b b       5 is light	  
    r b r       6 is heavy	  
    l b l       6 is light	  
    b r l       7 is heavy	  
    b l r       7 is light	  
    b r b       8 is heavy	  
    b l b       8 is light	  
    b r r       9 is heavy 	  
    b l l       9 is light	  
    r l r       10 is heavy	  
    l r l       10 is light	  
    l r b       11 is heavy	  
    r l b       11 is light	  
    b b r       12 is heavy	  
    b b l       12 is light   
    There are multiple comparison set possibilities, each with their own comparison table solution.




    A simpler solution #2:  

    put 6 coins on each side of the scale, one side will be heavier.
    use the heavier side from the first weighing and put 3 coins on each side of the scale.  
    using the heavier side from the 2nd weighing, pick 2 coins and put 1 on each side of the scale.  
    If the scale is balanced then the coin you didn't weigh is the heavier one. Otherwise, the scale will show which one of the other 2 is the heavy coin.  

    Since we do not know if the faulty coin is heavier or lighter , the soluition #2 is not correct




    The only solution is solution nr 1, for which we can also use a binary tree
  
  </p>
</details>
