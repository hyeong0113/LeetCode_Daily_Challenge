public class Solution {
    // My solution:
    //      Runtime: faster than 61.25%
    //      Memory Usage: less than 36.30%
    public void ReverseString(char[] s)
    {
        for(int i = 0; i < s.Length/2; i++)
        {
            char temp = s[i];
            s[i] = s[s.Length-i-1];
            s[s.Length-i-1] = temp;
        }
    }

    // Suggestion: https://leetcode.com/problems/reverse-string/discuss/1902861/C-or-Naive-approach-vs-Hat-vs-Array.Reverse-with-benchmark-results
    // Using Tuple instead of creating temp variable
    
    // Suggested solution:
    //      Runtime: faster than 42.70%
    //      Memory Usage: less than 87.72%

    // The suggested solution is more efficient in memory usage, but it is slower than using temp variable. 
    public void ReverseString(char[] s)
    {
      int len = s.Length;        
      for (int i = 0; i < len / 2; i++)
      {
          (s[i], s[len - 1 - i]) = (s[len - 1 - i], s[i]);
      }
    }

    // ^1 refers to the last element of an array, ^2 is the one before that, etc
    public void ReverseString(char[] s)
    {
        for (int i = 1; i <= s.Length / 2; i++)
        {
            (s[i - 1], s[^i]) = (s[^i], s[i - 1]);
        }
    }
}