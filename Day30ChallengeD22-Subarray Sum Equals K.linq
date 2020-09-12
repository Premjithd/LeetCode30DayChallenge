<Query Kind="Program" />

//D22
//Subarray Sum Equals K
//Given an array of integers and an integer k, you need to find the total number of continuous subarrays whose sum equals to k.

void Main()
{
	int[] array = {0,0,0,0,0,0,0,0,0,0};
	int k =0;
	int count = SubarraySum(array,k);
	count.Dump();
}

public int SubarraySum(int[] nums, int k) {
   
	if(nums.Length == 0) return 0;
	
	var map = new Dictionary<int,int>();
	int sum =0; int cnt = 0;
	
	for(int i = 0;i<nums.Length;i++)
	{
		
		sum += nums[i];
		
		if(sum == k)
		{
			cnt++;
		}
		
		if(map.ContainsKey(sum-k)){
			cnt += map[sum-k];
		}
		
		if(!map.ContainsKey(sum))
    	{
	 		map.Add(sum,1);
		}
		else map[sum]++;
	}
	
	return cnt;
}