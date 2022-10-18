public class Solution {
    // My solution:
    //      Runtime: faster than 39.11%
    //      Memory Usage: less than 91.80%
    // This is the second tries to finish this problem.
    public int SingleNumber(int[] nums) {
        int curr = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
          // When two same number are bitwised, they are cancelled (or sequence of all 0s).
          // As a result, only one number is left.
            curr = curr ^ nums[i];
        }
        
        return curr;
    }
}