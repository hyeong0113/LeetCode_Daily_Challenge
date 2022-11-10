// # Intuition
// The concern is identifying a single number in the given array. Other numbers consists of pairs of a number.

// # Approach
// Using bit operation was my thought. When two numbers are bitwised, using XOR operation, two identical bit become 0. If not, 1 is remained. With using this property, all duplicate numbers are cancelled, then only one number is left.

// # Complexity
// - Time complexity:
// It shows 91.50% better performance than average performance. Time complexity is O(n) since it iterates n times.

// - Space complexity:
// It shows 12.45% better performance than average performance. Space complexity is O(n) since it updates a variable n times during for loop.

// # Code
public class Solution {
    public int SingleNumber(int[] nums) {
        int current = nums[0];
        for(int i = 1; i < nums.Length; i++)
        {
            current = current ^ nums[i];
        }
        return current;
    }
}
