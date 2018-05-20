using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  [5] Suppose an arithmetic expression is given as a DAG (directed acyclic graph)
    with common subexpressions removed. Each leaf is an integer and each internal
    node is one of the standard arithmetical operations (+,−, ∗, /). For example, the
    expression 2 + 3 ∗ 4 + (3 ∗ 4)/5 is represented by the DAG in Figure 5.17(b). Give
    an O(n + m) algorithm for evaluating such a DAG, where there are n nodes and
    m edges in the DAG. Hint: modify an algorithm for the tree case to achieve the
    desired efficiency.
 * 
 * 
 * */

namespace Ch05
{
    public class AQ_10_EvaluateDAG
    {
        public void GetAnswer()
        {
            Tree<string> tree = AutoCreateTrees.AutoCreateTree_01_DAG_AQ10();
            Console.Write(Evaluate(tree.Root, true));

            Console.ReadLine();
        }

        /// <summary>
        /// Uses recursion to iterate through the graph going left and then right. It will replace the parent node, the operand,
        /// with the correct value for the numerals and the operands.
        /// </summary>
        /// <param name="node"></param>
        /// <returns>The value of the operation per left and right node recursive</returns>
        private int? Evaluate(TreeNode<string> node, bool print = false)
        {
            // do not need to go further if it is null
            if (node == null)
            {
                Console.Write("\n -- node is NULL");
                return null;
            }

            string nodeValue = node.Item;
            Console.Write($"\n [[nodeVal: {nodeValue} ]]");

            // if it is a numeral then convert to numeric and return value
            if (IsNumeric(nodeValue)) { return Convert.ToInt32(nodeValue); }

            int? leftValue = null;
            int? rightValue = null;

            // recurse through the left as long as there is a value, then recurse to the right
            if (node.Left != null) { leftValue = Evaluate(node.Left); }
            if (node.Right != null) { rightValue = Evaluate(node.Right); }

            if (node.Left != null) { leftValue = Evaluate(node.Left); Console.Write($" || LVal of [[{nodeValue}]]: {leftValue} || "); }
            if (node.Right != null) { rightValue = Evaluate(node.Right); Console.Write($" || RVal of [[{nodeValue}]]: {rightValue} || "); }

            // get the expected result for the left and right value and replace the parent value
            int? result = null;
            if (leftValue != null && rightValue != null)
            {
                Console.Write($"\n [[nodeVal: {nodeValue}]] LVal: {leftValue} && RVal: {rightValue}");

                switch (nodeValue)
                {
                    case "*":
                        result = leftValue * rightValue;
                        break;
                    case "+":
                        result = leftValue + rightValue;
                        break;
                    case "-":
                        result = leftValue - rightValue;
                        break;
                    case "/":
                        result = leftValue / rightValue;
                        break;
                }

                Console.WriteLine($"\n RESULT of [[nodeVal: {nodeValue}]] = {result}");
                node.SetItem(result.ToString());
            }

            return result;
        }


        #region Helper Methods

        private static bool IsNumeric(string input)
        {
            int test;
            return int.TryParse(input, out test);
        }

        #endregion
    }
}
