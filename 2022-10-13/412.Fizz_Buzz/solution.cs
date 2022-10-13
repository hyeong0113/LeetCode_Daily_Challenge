public class Solution {
    public IList<string> FizzBuzz(int n) {
      // My solution:
      //      Runtime: faster than 86.81%
      //      Memory Usage: less than 11.20%
      // Runtime is O(n) since this algorithm loops n times.
      // Other solutions are similar or more complicated, so this is simplest solutions to understand.
        IList<string> answer = new List<string>();
        for(int i = 1; i <= n; i++)
        {
            if(i%15 == 0)
            {
                answer.Add("FizzBuzz");
            }
            else if(i%5 == 0)
            {
                answer.Add("Buzz");
            }
            else if(i%3 == 0)
            {
                answer.Add("Fizz");
            }          
            else
            {
                answer.Add(i.ToString());
            }
        }
        
        return answer;
    }
}