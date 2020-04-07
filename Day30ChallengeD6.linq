<Query Kind="Program" />

	//Day 6
	//Group Anagrams
	//Given an array of strings, group anagrams together.
	//Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
	//Output:
	//[
	//  ["ate","eat","tea"],
	//  ["nat","tan"],
	//  ["bat"]
	//]
	
void Main()
{
//	List<string> st = new List<string> {"eat", "tea", "tan", "ate", "nat", "bat"};
	string[] st = {"eat", "tea", "tan", "ate", "nat", "bat"};
	
	IList<IList<string>> result = GroupAnagram(st);
	result.Dump();
	
}

public IList<IList<string>> GroupAnagram(string[] strs) // Better solution..
{
	if(strs.Length == 0) return new List<IList<string>>();
	var d = new Dictionary<string,List<string>>();
	var L = new List<IList<string>>();
	
	foreach(string s in strs)
	{
		char[] ch = s.ToCharArray();
		Array.Sort(ch);
		string sorted = new string(ch);
		
		if(d.ContainsKey(sorted)){
			d[sorted].Add(s);
		}
		else{
			d.Add(sorted,new List<string>{s});
		}
	}
	
	foreach(var item in d){
		L.Add(item.Value);
	}
	
	return L;
}

public List<List<string>> GroupAnagram1(string[] st) // Initial solition..
{
	if(st.Length == 0) return new List<List<string>>();
	
	List<List<string>> L = new List<List<string>>();
	var d = new Dictionary<string,int>();
	int n = 0;
	
	foreach(string s in st)
	{
		char[] charray = s.ToCharArray();
		Array.Sort(charray);
		string Str = new string(charray);
		if(!d.ContainsKey(Str))
		{
			d.Add(Str,n);
			n++;
		}
	}
	
	var dic = new Dictionary<string,List<string>>();
	
	for(int i = 0;i < n; i++)
	{
		dic.Add("List" + i,new List<string>());
	}
	
	
	foreach(string t in st)
	{
		char[] cArr = t.ToCharArray();
		Array.Sort(cArr);
		
		string Str = new string(cArr);
		
		if(d.ContainsKey(Str))
		{			
			dic["List" + d[Str]].Add(t);
		}
	}
	
	for(int i = 0;i < n; i++)
	{
		L.Add(dic["List" +i]);
	}
	
	return L;
}