<Query Kind="Program" />

//Day 10
//Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.
//
//push(x) -- Push element x onto stack.
//pop() -- Removes the element on top of the stack.
//top() -- Get the top element.
//getMin() -- Retrieve the minimum element in the stack.
void Main()
{
	
}

public class MinStack {

    public List<int> list;
    /** initialize your data structure here. */
    public MinStack() {
        list = new List<int>();
    }
    
    public void Push(int x) {
        list.Add(x);
    }
    
    public void Pop() {
        if(list.Count > 0) list.RemoveAt(list.Count-1);
    }
    
    public int Top() {
        if(list.Count > 0) return list[list.Count-1];
        else return 0;
    }
    
    public int GetMin() {
        return list.Min();
    }
}
