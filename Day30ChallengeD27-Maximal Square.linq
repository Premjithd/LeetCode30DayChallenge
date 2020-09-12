<Query Kind="Program" />

//D 27
//Maximal Square
//Given a 2D binary matrix filled with 0's and 1's, find the largest square containing only 1's and return its area.
void Main()
{
	char[][] arr = new char[][]{
	new char[]{'0','1'},
	new char[]{'1','0'}
	};
//	char[][] arr = new char[][]{
//	new char[]{'0','0','0','1'},
//	new char[]{'1','1','0','1'},
//	new char[]{'1','1','1','1'},
//	new char[]{'0','1','1','1'},
//	new char[]{'0','1','1','1'}
//	};

	int Area = MaximalSquare(arr);

	Area.Dump();
}

public int MaximalSquare(char[][] matrix) {
    
        int row = matrix.Length;

        if(row == 0) return 0;
        
        int column = matrix[0].Length;

        if(row == 1 || column == 1 ) {
         
            for(int k = 0; k < row; k++){
                for(int l=0;l<column;l++){
                   if(matrix[k][l] == '1') return 1;      
                }
            }
        }
        
        var max = 0;

        int[,] temp = new int[row+1,column+1];

        for(int i = 0; i<row;i++)
        {
            for(int j=0;j<column;j++)
            {
                int val = (int)Char.GetNumericValue(matrix[i][j]);

                if(val > 0)
                {  
                    if (temp[i,j] != 0 && temp[i+1,j] != 0 && temp[i,j+1] != 0) 
                    {
                        temp[i+1,j+1] = Math.Min(temp[i,j], Math.Min(temp[i+1,j],temp[i,j+1])) + 1;
                        max = Math.Max(max,temp[i+1,j+1]);
                    }
					else{
						temp[i+1,j+1] = val;
						max = Math.Max(max,1);
					}
                }
                else{
					temp[i+1,j+1] = val;
					
                }
            }
        }
        return max*max;
}
