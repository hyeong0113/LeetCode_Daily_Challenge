// # Intuition
// Since Inorder traversal traverses left subtree, node itself, then right subtree, recursive method is adoptable for this problem.

// # Approach
// As mentioned above, I approached this problem with recursive method. When the function recursives itself, it recursives the left subtree and add items after reaching the end of the tree. Then, it repeats on the right subtree after heading back to the root. For the solution, helper function is created to store appropriate values and prevent proceeding unnecessary steps when it reaches to children of the tree.

// # Complexity
// - Time complexity:
// It shows 32.23% better performance than average results. For time complexity, it is O(n) because of visiting all nodes in the tree.

// - Space complexity:
// It shows 46.18% better performance than average results. For space complexity, it is O(h) where h is the height of tree. The reason is, after visiting one node, their addresses are removed from the recursion stack. And, that space is reused when we are making a new call from a level that is closer to the root. So the maximum numbers of memory addresses on the stack at any given time are the tree height.


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

 // Inorder: LMR
public class Solution {
    public IList<int> result = new List<int>();
    public IList<int> InorderTraversal(TreeNode root) {
        InorderTraversalHelper(root);
        return result;
    }

    private void InorderTraversalHelper(TreeNode root)
    {
        if(root == null)
        {
            return;
        }
        InorderTraversalHelper(root.left);
        result.Add(root.val);
        InorderTraversalHelper(root.right);
    }
}
