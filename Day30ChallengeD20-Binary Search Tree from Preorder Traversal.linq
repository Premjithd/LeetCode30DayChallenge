<Query Kind="Program" />

// D20
//Construct Binary Search Tree from Preorder Traversal
//Return the root node of a binary search tree that matches the given preorder traversal.
//(Recall that a binary search tree is a binary tree where for every node, any descendant of 
//node.left has a value < node.val, and any descendant of node.right has a value > node.val.  
//Also recall that a preorder traversal displays the value of the node first, then traverses node.left, then traverses node.right.)
void Main()
{
	int[] inp = {8,5,1,7,10,12};
	
	TreeNode tr = BstFromPreorder(inp);
	tr.Dump();
}


	
public TreeNode BstFromPreorder(int[] preorder) {
    
	int l = preorder.Length;
	
	if(l==0) return null;
	
	if(l ==1) return new TreeNode(preorder[0]);
	TreeNode bstTree = new TreeNode(preorder[0]);

	constructTree(bstTree,preorder,l,1,int.MinValue,int.MaxValue);
	
//	bstTree.Dump();
	return bstTree;
}

public int constructTree(TreeNode temp,int[] preorder,int l,int pos,int min,int max)
{
	if(pos == l || preorder[pos] < min || preorder[pos] > max)
		return pos;
		
	if(preorder[pos] < temp.value){
		temp.left = new TreeNode(preorder[pos]);
		pos +=1;
		pos = constructTree(temp.left,preorder,l,pos,min,temp.value-1);
	}
	
	if(pos == l || preorder[pos] < min || preorder[pos] > max)
		return pos;
	
	if (preorder[pos] > temp.value){
		temp.right = new TreeNode(preorder[pos]);
		pos +=1;
		pos= constructTree(temp.right,preorder,l,pos,temp.value+1,max);
	}
	
	return pos;
}
	
public class TreeNode
{
	public int value;
	public TreeNode left;
	public TreeNode right;
	
	public TreeNode(int val)
	{
		value = val;
		left = null;
		right = null;
	}
}


//Check and understand this solution below

///**
// * Definition for a binary tree node.
// * public class TreeNode {
// *     public int val;
// *     public TreeNode left;
// *     public TreeNode right;
// *     public TreeNode(int x) { val = x; }
// * }
// */
//public class Solution {
//    public TreeNode BstFromPreorder(int[] preorder) {
//        if(preorder == null)
//            return null;
//        // root node will always be first node in preorder traversal
//        TreeNode root = new TreeNode(preorder[0]);
//        
//         // If we simply just insert all nodes in array 
//        // using standard way of inserting node in BST it will give us original tree.
//		
//        for(int x = 1; x<preorder.Length; x++)
//            InsertInBST(root, preorder[x]);
//        
//        return root;
//    }
//    
//    private void InsertInBST(TreeNode root, int val)
//    {
//        TreeNode current = root;
//        TreeNode parent = null;
//        while(current!=null)
//        {
//            parent = current;
//            current = current.val > val? current.left:current.right;
//        }
//        
//        if(parent.val > val)
//            parent.left = new TreeNode(val);
//        else
//            parent.right = new TreeNode(val);
//    }
//}