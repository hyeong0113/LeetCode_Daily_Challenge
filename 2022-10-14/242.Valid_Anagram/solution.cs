public class Solution {
    // My solution:
    //      Runtime: faster than 53.98%
    //      Memory Usage: less than 45.47%
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
            return false;
        }
        var sCharArray = s.ToCharArray();
        var tCharArray = t.ToCharArray();
        
        Array.Sort(sCharArray);
        Array.Sort(tCharArray);
        
        for(int i = 0; i < sCharArray.Length; i++)
        {
            if(sCharArray[i] != tCharArray[i])
            {
                return false;
            }
        }
        
        return true;
    }

    // Suggested solution:
    //      Runtime: faster than 70.47%
    //      Memory Usage: less than 91.53%
    public bool IsAnagram(string s, string t) {
      if (s.Length != t.Length)
          return false;

      char[] arr = new char[26];
      for (int i = 0; i < s.Length; i++)
      {
          arr[s[i] - 'a']++; // Increment when the letter exists
          arr[t[i] - 'a']--; // Decrement when the same letter exists in another string
                             // If so, total value is 0 when two strings have same letters
                             // ===> As a result, no need to sort two strings
      }

      return arr.All(c => c == 0);
    }      
}