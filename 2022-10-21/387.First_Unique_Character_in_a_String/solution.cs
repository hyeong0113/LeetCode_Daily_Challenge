public class Solution {
    // My solution:
    //      Runtime: faster than 12.05%
    //      Memory Usage: less than 54.70%   
    public int FirstUniqChar(string s) {
        IDictionary<char, int> dicString = new Dictionary<char, int>();

        for(int i = 0; i < s.Length; i++)
        {
            if(dicString.ContainsKey(s[i]))
            {
                dicString[s[i]]++;
                continue;
            }
            dicString.Add(s[i], 1);
        }
        
        for(int i = 0; i < s.Length; i++)
        {
            if(dicString[s[i]] == 1)
            {
                return i;
            }
        }
        
        return -1;
    }
}