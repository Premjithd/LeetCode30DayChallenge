//Longest Substring Without Repeating Characters - Leetcode

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length == 0) return 0;
        
        int MaxLen =0;
        
        var d = new HashSet<char>();
        int slow = 0;
        int fast = 0;
        
        while(fast < s.Length){
        
            if(!d.Contains(s[fast])){
                d.Add(s[fast]);
                fast++;
                MaxLen = Math.Max(d.Count,MaxLen);
            }
            else{
                d.Remove(s[slow]);
                slow++;
            }
        }
        
        return MaxLen;
        
    }
}
