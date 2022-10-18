public class Solution {
    // My solution:
    //      Runtime: faster than 86.95%
    //      Memory Usage: less than 96.39%  
    public bool ContainsDuplicate(int[] nums) {
        Array.Sort(nums);
        for(int i = 0; i < nums.Length-1; i++)
        {
            if(nums[i] == nums[i+1])
            {
                return true;
            }
        }
        return false;
    }
}