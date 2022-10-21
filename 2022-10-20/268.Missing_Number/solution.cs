public class Solution {
    // My solution:
    //      Runtime: faster than 92.51%
    //      Memory Usage: less than 6.6%
    // This is the fast algorithm since it iterates only n times, but it is inefficient in memory usage since
    // it generates another new array with size of n+1  
    public int MissingNumber(int[] nums) {
        int[] newNums = new int[nums.Length+1];
        
        for(int i = 0; i < nums.Length; i++)
        {
            newNums[nums[i]] = -1;
        }
        
        int result = -1;
        for(int i = 0; i < newNums.Length; i++)
        {
            if(newNums[i] != -1)
            {
                result = i;
                break;
            }
        }
        
        return result;
    }
    // My solution:
    //      Runtime: faster than 44.86%
    //      Memory Usage: less than 36.87%
    public int MissingNumber(int[] nums) {
        Array.Sort(nums);
        int result = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(result != nums[i])
            {
                break;
            }
            result++;
        }

        return result;
    }      
}