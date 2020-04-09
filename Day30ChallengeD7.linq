<Query Kind="Program" />

//Day 7
//Counting Elements
//Given an integer array arr, count element x such that x + 1 is also in arr.
//If there're duplicates in arr, count them seperately.

void Main()
{
	int[] arr = {1,3,2,3,5,0};
	
	int result = CountE(arr);
	result.Dump();
}

public int CountE(int[] arr)
{
	int l = arr.Length;
	int count=0;
	
	if(l == 0) return count;
	
	var d = new Dictionary<int,int>();
	
	foreach(int i in arr)
	{
		if(!d.ContainsKey(i))
			d.Add(i,1);
		else
			d[i]++;
	}
	
	for(int i=0;i<l;i++)
	{
		if(d.ContainsKey(arr[i] + 1))
		{
			count++;
			d[arr[i]]--;
		}
	}
	
	return count;
}