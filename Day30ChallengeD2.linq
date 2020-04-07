<Query Kind="Program" />

//Day 2
//Write an algorithm to determine if a number is "happy".
//A happy number is a number defined by the following process: Starting with any positive integer, replace the number by the sum of the squares of its digits, 
//and repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1. 
//Those numbers for which this process ends in 1 are happy numbers.

void Main()
{
	int inp = 8;
	
	bool IsHappy = CheckIfHappy(inp);
	IsHappy.Dump();
}

public bool CheckIfHappy(int n)
{
	if (n <= 0) return false;
	if (n == 1) return true;
	
	double num = 0;
	double temp = n;
//	int chktoBreak = 0;

	while(temp > 1 && temp < int.MaxValue)
	{
		while(temp > 0){
			int t = (int)temp%10;
			num = num + Math.Pow(t,2);
//			t.Dump();
//			num.Dump();
			temp = temp/10;
		}
		
		if (num == 1) return true;
		if (num == 4) return false;
//		if(num < 10) {
//			if(chktoBreak == 0 || num != chktoBreak)	chktoBreak = (int)num;
//			else if(num == chktoBreak) return false;
//		}
		num.Dump();
		temp = num;
		num=0;
	}
	
	return false;
}
