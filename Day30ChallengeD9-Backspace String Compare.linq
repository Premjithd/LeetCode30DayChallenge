<Query Kind="Program" />

//Day 9
//Backspace String Compare
//Given two strings S and T, return if they are equal when both are typed into empty text editors. # means a backspace character.
void Main()
{
	string s = "ab##";
	string t = "c#d#";
	
	bool istrue = IsBacktrackTrue(s, t);
	istrue.Dump();
}

public bool IsBacktrackTrue(string s, string t)
{
	string ss = Process1(s);
	string st = Process1(t);
	
	ss.Dump();
	st.Dump();
	return (ss==st);
}

public string Process1(string s)  // Better solution
{
    var list = new List<Char>();
	int l = s.Length;
	
	foreach(char c in s)
	{
		if(c == '#') 
		{
			if(list.Count > 0){
				list.RemoveAt(list.Count-1); 
			}
		}
		else{
			list.Add(c);
		}
	}
	return new string(list.ToArray());
}

string Process(string s) // Initial solution
{
	var SB = new StringBuilder(s);
	
	int l = SB.Length;
	int i = 1;
	
	while(i < l)
	{
		if(SB[0].ToString() == "#") {SB.Remove(0,1); l--;}
		
		if(!Char.IsLetter(SB[i]))
			{
			    SB.Remove(i-1,2);
				
				l=l-2;
				i=1;
			}
		else {
			i++;
		}
	}
	SB.Dump();
	return SB.ToString();
}