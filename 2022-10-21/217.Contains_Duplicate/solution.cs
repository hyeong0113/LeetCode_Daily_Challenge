public class Solution {
    // My solution:
    //      Runtime: faster than 73.11%
    //      Memory Usage: less than 95.58%  
    public bool ContainsDuplicate(int[] nums) {
        HashSet<int> numsCollection = new HashSet<int>();
        
        for(int i = 0; i < nums.Length; i++)
        {
            if(numsCollection.Contains(nums[i]))
            {
                return true;
            }
            numsCollection.Add(nums[i]);
        }
        return false;
    }

    // My solution:
    //      Runtime: faster than 22.13%
    //      Memory Usage: less than 95.58%
    // This is impressive by using Distinct function but not efficient in runtime 
    public bool ContainsDuplicate(int[] nums) {
      if (nums.Distinct().Count() == nums.Length)
		    return false;
	    return true; 
    }    
}