<Query Kind="Program" />

//D 15
//Product of Array Except Self
//Given an array nums of n integers where n > 1,  return an array output such that output[i] is equal 
//to the product of all the elements of nums except nums[i].
void Main()
{
	int[] inp = {1,2,3,4};
	
	int[] output = GetProduct(inp); 
	output.Dump();
}

public int[] GetProduct1(int[] nums) //Optimal solution
{		
		int l = nums.Length;

        if (l == 1) { 
            return nums; 
        } 
		
        int temp = 1; 
  
        int[] prod = new int[l]; 
    
        for (int i = 0; i < l; i++) { 
            prod[i] = temp; 
            temp *= nums[i]; 
        } 
  
        temp = 1; 
  
        for (int j = l - 1; j >= 0; j--) { 
            prod[j] *= temp; 
            temp *= nums[j]; 
        } 
    
        return prod; 
}

public int[] GetProduct(int[] nums) //Solution with divide
{		
		int l = nums.Length;

        if (l == 1) { 
            return nums; 
        } 
		
        int product = 1; 
  		bool containszero = false;
		int totalzeros = 0;
		
        int[] prod = new int[l]; 
    
        for (int i = 0; i < l; i++) { 
			if(nums[i] != 0 )
				product *= nums[i]; 
			else{
				totalzeros++;
				containszero = true;
			}
        } 
  		
		product.Dump();
		totalzeros.Dump();
		containszero.Dump();
        for (int j = 0; j < l; j++) { 
            if(totalzeros == 0 && !containszero)
				prod[j] = product/nums[j];
            else if(totalzeros == 1 && containszero){
//					nums[j].Dump();
//					j.Dump();
					if(nums[j] == 0)		
						prod[j] = product;
					else
						prod[j] = 0;
			}
			else if(totalzeros > 1 && containszero){
				prod[j] = 0;
        	}
		}
    
        return prod; 
}