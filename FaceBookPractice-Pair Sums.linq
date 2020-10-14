Pair Sums
Given a list of n integers arr[0..(n-1)], determine the number of different pairs of elements within it which sum to k.
If an integer appears in the list multiple times, each copy is considered to be different; that is, two pairs are considered different if one pair includes at least one array index which the other doesn't, even if they include the same values.
Signature
int numberOfWays(int[] arr, int k)
Input
n is in the range [1, 100,000].
Each value arr[i] is in the range [1, 1,000,000,000].
k is in the range [1, 1,000,000,000].
Output
Return the number of different pairs of elements which sum to k.
Example 1
n = 5
k = 6
arr = [1, 2, 3, 4, 3]
output = 2
The valid pairs are 2+4 and 3+3.
Example 2
n = 5
k = 6
arr = [1, 5, 3, 3, 3]
output = 4
There's one valid pair 1+5, and three different valid pairs 3+3 (the 3rd and 4th elements, 3rd and 5th elements, and 4th and 5th elements).

-----------------------------------------
using System;
using System.Collections.Generic;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
class PairSums {
  static void Main(string[] args) {
    int[] arr = {1, 3, 3, 3, 3};
    int result = numberOfWays(arr, 6);
    
    Console.WriteLine("Result: " + result);
  }
  
  private static int numberOfWays(int[] arr, int k) {
    long len = arr.Length;
    if(len <= 1) return 0;
    
    var d = new Dictionary<long,long>();
    
    foreach(long i in arr){
      if(d.ContainsKey(i)) d[i]++;
      else d.Add(i,1);
    }
    
    long count = 0;
    foreach(var dic in d){
      long other = k - dic.Key;
      
      if(d.ContainsKey(other)){
         if(d[other] ==1){
           count++;
         }
        else if(d[other] > 1) {
          count = count + ((d[other]* (d[other]-1)));
         }
      }
    }

    return Convert.ToInt32(count/2);
  }
}