<Query Kind="Program" />

//D 16
//Valid Parenthesis String
//Given a string containing only three types of characters: '(', ')' and '*', write a function to check whether this string is valid. We define the validity of a string by these rules:
//
//1.Any left parenthesis '(' must have a corresponding right parenthesis ')'.
//2.Any right parenthesis ')' must have a corresponding left parenthesis '('.
//3.Left parenthesis '(' must go before the corresponding right parenthesis ')'.
//4.'*' could be treated as a single right parenthesis ')' or a single left parenthesis '(' or an empty string.
//5.An empty string is also valid.

void Main()
{
	string inp = "*()(())*()(()()((()(()()*)(*(())((((((((()*)(()(*)";
	
	bool isValid = CheckValidString(inp);
	isValid.Dump();
}

public bool CheckValidString(string s)
{
	if(string.IsNullOrEmpty(s)) return true;

	char[] ch = s.ToCharArray();
	
	var st = new Stack<int>();
	var Cst = new Stack<int>();
		
	for(int i = 0;i<ch.Length;i++)
	{
		if(ch[i] == '('){
			st.Push(i);
		}
		else if(ch[i] == '*'){
			Cst.Push(i);
		}
		else {
			if(st.Count >0){
				st.Pop();
			}
			else {
				if(Cst.Count > 0){
					if(Cst.Peek() < i){
						Cst.Pop();
					}
					else{
						return false;
					}
				}
				else 
					return false;
			}
		}
	}
	
	st.Dump();
	Cst.Dump();
	while(st.Count > 0){
		
		if(Cst.Count > 0){
			if(Cst.Peek() > st.Peek()){
				st.Pop();
				Cst.Pop();
			}
			else 
				return false;
		}
		else
			return false;
	}
	
	return true;
}
	
	
