<Query Kind="Program" />

//Day 1
//Given a non-empty array of integers, every element appears twice except for one. Find that single one.
	
void Main()
{
	int[] arr = {1,1,1,1,2,2,3,4,5,3,5};
	
	int val = FindSingleOccuranceNoMem(arr);

	val.Dump();
}

public int FindSingleOccuranceNoMem(int[] arr)
{
	int l = arr.Length;
	
	if(l == 0) return -1;
	if(l == 1) return arr[0]; 
	
	var d = new HashSet<int>();
	
	foreach(int i in arr)
	{
		if(d.Contains(i)) 
			 d.Remove(i);
		else d.Add(i);
	}
	
	foreach(int i in d)
	{
		return i;
	}
	
	return -1;
}
public int FindSingleOccuranceDic(int[] arr)
{
	int l = arr.Length;
	
	if(l == 0) return -1;
	if(l == 1) return arr[0]; 
	
	var d = new Dictionary<int,int>();
	
	foreach(int i in arr)
	{
		if(d.ContainsKey(i)) d[i]++;
		else d.Add(i,1);
	}
	
	foreach(int j in arr)
	{
		if(d[j] == 1) return j;
	}
	
	return -1;
}