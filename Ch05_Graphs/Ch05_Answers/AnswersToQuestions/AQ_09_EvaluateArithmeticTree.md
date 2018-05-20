5-9. Suppose an arithmetic expression is given as a tree. Each leaf is an integer and each internal node is one of the standard arithmetical operations (+,−,∗,/). For example, the expression 2+3∗4+(3∗4)/5 is represented by the tree in Figure (see book)(a). 

(see book for figure) 

(see book for figure) Give an O(n) algorithm for evaluating such an expression, where there are n nodes in the tree.


<details>
<summary>**ANSWER**</summary>
  <p>

  You can solve this problem by doing a DFS on the graph. Each node can be an operation or a literal. Literal will be leaves in the graph and operations will always have in this case both children. The recursive function "evaluates" the expression represented by each child node and then calculates the final result by applying the operation represented by the current node.

Here is an implementation in Java:

	class Main {

		public static void main(String[] args) {
			Node expression = new Addition(new Addition(new Literal(1), new Literal(2)),
					new Literal(3));
			System.out.println(expression.evaluate());
		}

		static interface Node {
			int evaluate();
		}

		static class Literal implements Node {
			int val;

			Literal(int val) {
				this.val = val;
			}

			@Override
			public int evaluate() {
				return val;
			}
		}

		static abstract class Op implements Node {
			Node operand1;
			Node operand2;

			Op(Node operand1, Node operand2) {
				this.operand1 = operand1;
				this.operand2 = operand2;
			}
		}

		static class Addition extends Op {
			Addition(Node operand1, Node operand2) {
				super(operand1, operand2);
			}

			@Override
			public int evaluate() {
				return operand1.evaluate() + operand2.evaluate();
			}
		}

		static class Substraction extends Op {
			Substraction(Node operand1, Node operand2) {
				super(operand1, operand2);
			}

			@Override
			public int evaluate() {
				return operand1.evaluate() - operand2.evaluate();
			}
		}

		static class Division extends Op {
			Division(Node operand1, Node operand2) {
				super(operand1, operand2);
			}

			@Override
			public int evaluate() {
				return operand1.evaluate() / operand2.evaluate();
			}
		}

		static class Multiplication extends Op {
			Multiplication(Node operand1, Node operand2) {
				super(operand1, operand2);
			}

			@Override
			public int evaluate() {
				return operand1.evaluate() / operand2.evaluate();
			}
		}

	}


  </p>
</details>

