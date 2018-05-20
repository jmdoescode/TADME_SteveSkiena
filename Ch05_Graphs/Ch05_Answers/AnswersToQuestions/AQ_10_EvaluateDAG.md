5-10 Suppose an arithmetic expression is given as a DAG (directed acyclic graph) with common subexpressions removed. Each leaf is an integer and each internal
node is one of the standard arithmetical operations (+,−, ∗, /). For example, the expression 2 + 3 ∗ 4 + (3 ∗ 4)/5 is represented by the DAG in Figure 5.17(b). Give an O(n + m) algorithm for evaluating such a DAG, where there are n nodes and m edges in the DAG. Hint: modify an algorithm for the tree case to achieve the desired efficiency.

<details>
<summary>**ANSWER**</summary>
  <p>
  
  [Answer Here](../../Ch05_Answers/AnswersToQuestions/AQ_10_EvaluateDAG.cs)

  Summary

  You will use recursion and go all the way down the left and then the right replacing the node with an operator with the correct arithmetic value of the left and right node based on the operator. 

  - Create a method that will receieve a Tree Node
  - If the node is a numeral, convert it to a numeric and return that value
  - as long as there is a value in the left node, recurse
  - as long as there is a value in the right node recurse
  - if the left and right value are not null
	- case statement - depending on the operator value of the node
		- do the correct arithmetic
	- set the value of the current node to the correct arithmetic value based on the operator in the case statement
  - return the node value


  </p>
</details>