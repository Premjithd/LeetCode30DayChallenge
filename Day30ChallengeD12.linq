<Query Kind="Program" />

//Day 12
//Last Stone Weight
//We have a collection of stones, each stone has a positive integer weight.
//
//Each turn, we choose the two heaviest stones and smash them together.  Suppose the stones have weights x and y with x <= y.  The result of this smash is:
//
//	If x == y, both stones are totally destroyed;
//	If x != y, the stone of weight x is totally destroyed, and the stone of weight y has new weight y-x.
//At the end, there is at most 1 stone left.  Return the weight of this stone (or 0 if there are no stones left.)

void Main()
{
	int[] st = {2,7,4,1,8,1};
	int num = findNum(st);
	num.Dump();
}

public int findNum(int[] stones)  // First and better solution
{
	    List<int> stoneList = new List<int>();
        
        foreach(int n in stones)
        {
            stoneList.Add(n);
        }
        
        int i = stones.Length;
        while(i>1)
        {
            int x = stoneList.Max();            
            stoneList.Remove(stoneList.Max());
            stoneList.Dump();
            int y = stoneList.Max();
            stoneList.Remove(stoneList.Max());
            stoneList.Dump();
			
            if(x != y)
            {
                y = x-y;
                stoneList.Add(y);
            }

			i = stoneList.Count;
        }
        
        if(stoneList.Count == 1) return stoneList[0];
        else  return 0;
}
