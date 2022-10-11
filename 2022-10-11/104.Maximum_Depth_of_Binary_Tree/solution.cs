public class Solution {
    // My solution:
    //      Runtime: faster than 59.69%
    //      Memory Usage: less than 55.16%
    public int MaxDepth(TreeNode root)
    {
        if(root == null)
        {
            return 0;
        }
        
        int left = 1 + MaxDepth(root.left);
        int right = 1 + MaxDepth(root.right);
        
        if(left < right)
        {
            return right;
        }
        
        return left;
    }

    // Suggested solution:
    //      Runtime: faster than 40.81%
    //      Memory Usage: less than 90.22%

    // Other solutions do not show significant differences, but this solution shows better performance in memory usage.
    public int MaxDepth(TreeNode node) {
        return node == null ? 0 : Math.Max(MaxDepth(node.left), MaxDepth(node.right)) + 1;
    }
}