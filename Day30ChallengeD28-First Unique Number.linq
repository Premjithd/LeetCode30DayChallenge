<Query Kind="Program" />

//D 28
//First Unique Number
//You have a queue of integers, you need to retrieve the first unique integer in the queue.
//
//Implement the FirstUnique class:
//
//* FirstUnique(int[] nums) Initializes the object with the numbers in the queue.
//* int showFirstUnique() returns the value of the first unique integer of the queue, and returns -1 if there is no such integer.
//* void add(int value) insert value to the queue.
void Main()
{
	
}

    Dictionary<int,int> dic = new Dictionary<int,int>();
    List<int> list;
    
    public void FirstUnique(int[] nums) {
        
        list = new List<int>(nums);
        
        foreach(int i in list)
        {
            if(dic.ContainsKey(i)){
                dic[i]++;
            }
            else dic.Add(i,1);
        }

    }
    
    public int ShowFirstUnique() {
        
        foreach(var i in dic.Keys){
            if(dic[i] == 1) return i;
        }
        
        return -1;
    }
    
    public void Add(int value) {
     
        list.Add(value);
        
                if(dic.ContainsKey(value)){
                    dic[value]++;
                }
                else dic.Add(value,1);
    }