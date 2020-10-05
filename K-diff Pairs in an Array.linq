//Given an array of integers nums and an integer k, return the number of unique k-diff pairs in the array.
//A k-diff pair is an integer pair (nums[i], nums[j]), where the following are true:
//
//0 <= i, j < nums.length
//i != j
//a <= b
//b - a == k
// 
public class Solution {
    public int FindPairs(int[] inp, int k) {

        int l = inp.Length;
        if(l <= 1) return 0;
        
        var d = new Dictionary<int,int>();
        int count = 0;
        
        foreach(int a in inp){
            if(d.ContainsKey(a)) 
                d[a]++;
                else
                d.Add(a,1);
        }
        
        foreach(var dic1 in d)
        {
            int other = dic1.Key + k;
            if(d.ContainsKey(other)){
                if(k==0 && d[other] >1){
                    count++;
                }
                else if(k != 0 && d[other] > 0){
                    count++;
                }
            }
        }
        
        return count;
       
    }
}