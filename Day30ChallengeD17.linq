<Query Kind="Program" />

//// D17
//Number of Islands
//Given a 2d grid map of '1's (land) and '0's (water), count the number of islands. An island is surrounded by water and is formed by 
//connecting adjacent lands horizontally or vertically. 
//You may assume all four edges of the grid are all surrounded by water.
void Main()
{
	char[][] grid = 
	{ 
		new char[]{ '1', '1', '1' }, 
		new char[]{ '1', '0', '0' }, 
		new char[]{ '1', '0', '1' } 
	};	
	
	int Islands = NumIslands(grid);
	Islands.Dump();
}

public int NumIslands(char[][] grid) 
{
	if(grid.Length == 0) return 0;
	int rows = grid.Length;
	int cols = grid[0].Length;
	int Islands = 0;
	
	for(int i = 0;i<rows;i++)
	{
		for(int j=0;j<cols;j++)
		{
			if(grid[i][j] == '1')
			{
				Islands++;
				markNeighbours(grid,i,j);
			}
		}
	}
	
	grid.Dump();
	return Islands;
}

void markNeighbours(char[][] grid, int i , int j)
{
	if(i <0 || j <0 || i >grid.Length-1|| j >grid[0].Length-1 || grid[i][j]!='1')
		return;
	
		grid[i][j] = '2';
		
		markNeighbours(grid,i+1,j);
		markNeighbours(grid,i,j+1);	
		markNeighbours(grid,i-1,j);
		markNeighbours(grid,i,j-1);
}

