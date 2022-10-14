public class Solution {
    // My solution:
    //      Runtime: faster than 96.72%
    //      Memory Usage: less than 33.04%
    // This is quite long and repetitive  
    public int MajorityElement(int[] nums) {
        int majChance = nums.Length/2;
        Array.Sort(nums);
        
        int currResult = nums[0];
        int maxResult = currResult;
        int chance = 1;
        int maxChance = chance;
        
        for(int i = 1; i < nums.Length; i++)
        {
            if(currResult == nums[i])
            {
                chance++;
            }
            else
            {
                if(chance > maxChance)
                {
                    maxResult = currResult;
                    maxChance = chance;
                }
                currResult = nums[i];
                chance = 1;
            }
        }
        
        if(chance > maxChance)
        {
            maxResult = currResult;
            maxChance = chance;
        }
        return maxResult;
    }

    // Boyer-Moore Voting Algorithm
    // If we had some way of counting instances of the majority element as +1+1 and instances of any other element as -1−1,
    // summing them would make it obvious that the majority element is indeed the majority element.

    // Suggested solution:
    //      Runtime: faster than 49.93%
    //      Memory Usage: less than 85.64%
    public int MajorityElement(int[] nums) {
        int count = 0;
        int? candidate = null;
        
        foreach(int num in nums)
        {
            if(count == 0)
            {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }
        return (int)candidate;
    }
}