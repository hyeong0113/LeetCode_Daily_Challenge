// Inorder: L-M-R
public class Solution {
    // My solution:
    //      Runtime: faster than 29.91%
    //      Memory Usage: less than 91.18%
    // This is the most efficient solution in memory usage
    private IList<int> numberList = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        if(root == null)
        {
            return numberList;
        }
        
        InorderTraversal(root.left);
        numberList.Add(root.val);
        InorderTraversal(root.right);
        return numberList;
    }
    
    // Suggested solution:
    //      Runtime: faster than 17.01%
    //      Memory Usage: less than 43.10%
    // Using Stack and recursive using while loop
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        TreeNode curr = root;
        while (curr != null || stack.Count != 0) {
            while (curr != null) {
                stack.Push(curr);
                curr = curr.left;
            }
            curr = stack.Pop();
            res.Add(curr.val);
            curr = curr.right;
        }
        return res;
    }
    
    // Suggested solution:
    //      Runtime: faster than 80.93%
    //      Memory Usage: less than 21.61%
    
    // Using Morris Traversal:
    //    https://www.educative.io/answers/what-is-morris-traversal
    // This is the most efficient solution in runtime
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> res = new List<int>();
        TreeNode curr = root;
        TreeNode pre;
        while (curr != null) {
            if (curr.left == null) {
                res.Add(curr.val);
                curr = curr.right; // move to next right node
            } else { // has a left subtree
                pre = curr.left;
                while (pre.right != null) { // find rightmost
                    pre = pre.right;
                }
                pre.right = curr; // put cur after the pre node
                TreeNode temp = curr; // store cur node
                curr = curr.left; // move cur to the top of the new tree
                temp.left = null; // original cur left be null, avoid infinite loops
            }
        }
        return res;
    }    
}