<Query Kind="Program" />

////D18
//Minimum Path Sum
//Given a m x n grid filled with non-negative numbers, find a path from top left to bottom right which minimizes the sum of all numbers along its path.
//Note: You can only move either down or right at any point in time.
void Main()
{
	int[][] input = {
  			new int[] {1,3,1},
  			new int[] {1,5,1},
  			new int[] {4,2,1}
			};
	int minpath = MinPathSum(input);
	minpath.Dump();
}

public int MinPathSum(int[][] grid) {
	
	int row = grid.Length;
	if(grid.Length == 0) return 0;
	
	int col = grid[0].Length;
	
	int[,] d = new int[row,col];
	
	d[0,0] = grid[0][0];
	
	for(int i=1;i<row;i++)
	{
		d[i,0] = d[i-1,0] + grid[i][0];
	}

d.Dump();
	for(int j=1;j<col;j++)
	{
		d[0,j] = d[0,j-1] + grid[0][j];
	}

	d.Dump();
	
	for(int k=1;k<row;k++)
	{
		for(int l=1;l<col;l++)
		{
			d[k,l] = Math.Min(d[k-1,l],d[k,l-1]) + grid[k][l];
		}
	}
	
	return d[row-1,col-1];
}