// # Intuition
// When I see this problem, I decide to calcualte maximum depth by comparing length of left subtree and right subtree.

//# Approach
//Recursive method is used. When the method hits the child of tree, it returns 0. Otherwise, increase the length of tree after comparing length of left subtree and right subtree. 

// # Complexity
// - Time complexity:
// It shows 78.77% better performance than average. Average time complexity shows O(n) since it visits half size of its subtree at every recursion.

// - Space complexity:
// It shows 31.96% better performance than average. Average or best case space complexity shows O(logn) for balanced tree since it is affected by recursion call stack. For the worst-case scenario, it shows O(n) for sekewed tree.

// # Code
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root == null)
        {
            return 0;
        }

        return Math.Max(MaxDepth(root.left), MaxDepth(root.right)) + 1;
    }
}
