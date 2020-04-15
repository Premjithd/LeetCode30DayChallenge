<Query Kind="Program" />

//D 13
//Contiguous Array
//Given a binary array, find the maximum length of a contiguous subarray with equal number of 0 and 1
void Main()
{
	int[] inp = {0, 0, 1, 0, 0, 0, 1, 1};
	
	int maxlength = FindMax(inp);
	maxlength.Dump();
}

public int FindMax(int[] nums)
{
	if(nums.Length == 0) return 0;
	
	var d = new Dictionary<int,int>();
	int count = 0;
	int max = 0;
	for(int i=0;i < nums.Length;i++)
	{
		count = count + (nums[i] == 1? 1: -1);
		
		if(d.ContainsKey(count)) {
			int len = i - d[count];
			max = Math.Max(max,len);
		}
		else{
			d.Add(count,i);
		}
		
	}
	
	return max;
}

