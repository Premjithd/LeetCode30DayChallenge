<Query Kind="Program" />

// Day 3
//Maximum Subarray
//Given an integer array nums, find the contiguous subarray (containing at least one number) which has the largest sum and return its sum.

void Main()
{
	int[] arr = {-2,1,-3,4,-1,2,1,-5,4};
	int max = FindMax(arr);
	
	max.Dump();
}

static int FindMax(int[] arr)
{
	int max = 0;
	int currentMax = 0;

	for (int i=0;i<arr.Length;i++)
	{
		currentMax = currentMax + arr[i];
		
		if(currentMax < 0) currentMax = 0;

		max = Math.Max(currentMax,max);
	}

	return max;
}

public int FindMax2(int[] arr) // General for all 3 conditions (all +ve, all -ve and mix)
{
	int max = arr[0];
	int currentMax = arr[0];
	
	for (int i=1;i<arr.Length;i++)
	{
		currentMax = Math.Max(arr[i], arr[i] + currentMax);
		max = Math.Max(max,currentMax);
	}
	
	return max;
}