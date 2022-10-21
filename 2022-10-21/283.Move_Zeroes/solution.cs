public class Solution {
    // My solution:
    //      Runtime: faster than 92.04%
    //      Memory Usage: less than 12.79%
    // This is the fast algorithm since it iterates only n times
    public void MoveZeroes(int[] nums) {
        int numZero = 0;
        int index = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == 0)
            {
                numZero++;
            }
            else
            {
                nums[index] = nums[i];
                index++;
            }
        }
        
        for(int i = 0; i < numZero; i++)
        {
            nums[nums.Length - 1 - i] = 0;
        }
    }
}