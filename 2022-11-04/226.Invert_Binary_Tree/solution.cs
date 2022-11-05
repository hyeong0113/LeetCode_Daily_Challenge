//# Intuition
//When I saw this problem, I decided to swap nodes from the bottom, or child nodes, to the root.

//# Approach
//To accomplish my strategy, I should use recursive function to reach out to end of tree and both subtrees.

//# Complexity
//Time complexity: 83.90% O(nlogn)

//# Space complexity:
//14.67% O(n/2) since creating new temp node for the right subtree —>

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
    public TreeNode InvertTree(TreeNode root) {
        if(root == null)
        {
            return null;
        }
        TreeNode temp = root.right;
        root.right = InvertTree(root.left);
        root.left = InvertTree(temp);
        return root;
    }
}