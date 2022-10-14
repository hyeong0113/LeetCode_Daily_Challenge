public class Solution {
    // My solution:
    //      Runtime: faster than 96.95%
    //      Memory Usage: less than 13.58%
    // I tried to solve this problem twice, but there is an error on line 8 by misunderstanding of range.
    public TreeNode SortedArrayToBST(int[] nums) {

        return SortedArrayToBSTHelper(0, nums.Length-1, nums);
    }
    
    private TreeNode SortedArrayToBSTHelper(int start, int end, int[] nums)
    {
        if(start > end)
        {
            return null;
        }
        
        int mid = (start + end)/2;
        TreeNode midNode = new TreeNode(nums[mid]);
        midNode.left = SortedArrayToBSTHelper(start, mid-1, nums);
        midNode.right = SortedArrayToBSTHelper(mid+1, end, nums);
        
        return midNode;
    }
}