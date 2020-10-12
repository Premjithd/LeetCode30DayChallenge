using System;
using System.Collections.Generic;

// To execute C#, please define "static void Main" on a class
// named Solution.

class Solution
{
    static void Main(string[] args)
    {
        
        string s = "ABCD";
        
        Calculate(s,0,s.Length-1);
        
        foreach (var i in output)
        {
            Console.WriteLine(i);
        }
    }
    
    public static List<string> output = new List<string>();
    
    public static void Calculate(string s, int start, int end)
    {
       if(start == end) output.Add(s);
        else{
            for(int i = start;i<=end;i++){
                string swapstr = DoSwap(s,start,i);
                Calculate(swapstr,start+1,end);
            }
        }
        
    }
    
    public static string DoSwap(string str, int l,int r){
        if(l == r) return str;
        
        char temp;
        
        char[] ch = str.ToCharArray();
        
        temp = ch[l];
        ch[l] = ch[r];
        ch[r] = temp;
        
        return new string(ch);
    }
}
