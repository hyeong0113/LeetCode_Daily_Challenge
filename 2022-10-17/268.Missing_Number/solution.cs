public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int[] arr = new int[n+1];
        
        for(int i = 0; i < nums.Length; i++)
        {
            arr[nums[i]] = -1;
        }
        int result = 0;
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == 0)
            {
                result = i;
            }
        }
        
        return result;
    }

    public int MissingNumber(int[] nums) {
        Array.Sort(nums);
        int index = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != index)
            {
                return index;
            }
            index++;
        }
        
        return index;
    }    
}