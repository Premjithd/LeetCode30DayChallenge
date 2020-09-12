<Query Kind="Program" />

//D 14
//Perform String Shifts
//You are given a string s containing lowercase English letters, and a matrix shift, where shift[i] = [direction, amount]:
//
//direction can be 0 (for left shift) or 1 (for right shift). 
//amount is the amount by which string s is to be shifted.
//A left shift by 1 means remove the first character of s and append it to the end.
//Similarly, a right shift by 1 means remove the last character of s and add it to the beginning.
//Return the final string after all operations.

void Main()
{
	string s = "wpdhhcj"; 
	int[][] shift = {
		new int[]{0,7},
		new int[]{1,7},
		new int[]{1,0},
		new int[]{1,3},
		new int[]{0,3},
		new int[]{0,6},
		new int[]{1,2}
	};
	string str = StringShift(s,shift);
	
	str.Dump();
}

public string StringShift(string s, int[][] shift) {
        
		int direction;
		int amount = 0;
		for(int i=0;i<shift.Length;i++)
		{
			if(shift[i][0] == 0)  amount -= shift[i][1];
			else amount+= shift[i][1];
		}
	
		if(amount== 0) return s;
		direction = (amount > 0 ? 1: 0);

		if(amount < 0) amount= amount*-1;
		amount = amount % s.Length;
		
		amount.Dump();
		direction.Dump();
		string result  = string.Empty;
		if (direction == 1)
		 	result = rotateForward(s,amount);
		else
			result = rotateBackward(s,amount);
			
		return result;	
}
public string rotateForward(string s, int amount)
{
	char[] ch = s.ToCharArray();
	rotate(ch,ch.Length-amount, ch.Length-1);
	rotate(ch,0,ch.Length-amount-1);
	rotate(ch,0,ch.Length-1);
	
	return new string(ch);
}

public string rotateBackward(string s, int amount)
{
	char[] ch = s.ToCharArray();
	rotate(ch,0,amount-1);
	rotate(ch,amount,ch.Length-1);
	rotate(ch,0,ch.Length-1);
	
	return new string(ch);
}


public void rotate(char[] ch, int sindx,int eindx)
{
	int i=0;
	int k=0;
	for (i=sindx, k=eindx;i<k;i++,k--)
	{
		char temp = ch[i];
		ch[i] = ch[k];
		ch[k] = temp;
	}
}