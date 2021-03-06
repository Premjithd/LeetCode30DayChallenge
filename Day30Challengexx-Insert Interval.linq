//Given a set of non-overlapping intervals, insert a new interval into the intervals (merge if necessary).
//You may assume that the intervals were initially sorted according to their start times.
//Example 1:

//Input: intervals = [[1,3],[6,9]], newInterval = [2,5]
//Output: [[1,5],[6,9]]
//Example 2:
//
//Input: intervals = [[1,2],[3,5],[6,7],[8,10],[12,16]], newInterval = [4,8]
//Output: [[1,2],[3,10],[12,16]]
//Explanation: Because the new interval [4,8] overlaps with [3,5],[6,7],[8,10].

public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
        
        //if(intervals.Length == 0) return new int[][]{new int[]{0}};
        
        List<int[]> outList = new List<int[]>();
        
        foreach(var i in intervals){
            
            if(i[1] < newInterval[0]){
                outList.Add(i);
            }
            else if(i[0] > newInterval[1]){
                outList.Add(newInterval);
                newInterval = i;
            }
            else{
                newInterval[0] = Math.Min(newInterval[0],i[0]);
                newInterval[1] = Math.Max(newInterval[1],i[1]);
            }
            
        }
        
        outList.Add(newInterval);
        
        return outList.ToArray();
        
    }
}