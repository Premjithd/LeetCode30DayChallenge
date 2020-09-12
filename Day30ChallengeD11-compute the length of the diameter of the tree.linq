<Query Kind="Program" />

//Day 11
//Given a binary tree, you need to compute the length of the diameter of the tree. 
//The diameter of a binary tree is the length of the longest path between any two nodes in a tree. 
//This path may or may not pass through the root.
void Main()
{
	TreeNode root = new TreeNode(1);
	root.left = new  TreeNode(2);
	root.right = new TreeNode(3);
	root.left.left = new TreeNode(4);
	root.left.right = new TreeNode(5);
	
	
	int d = DiameterOfBinaryTree(root);
	d.Dump();
}


	int diameter;
    public int DiameterOfBinaryTree(TreeNode root) {
        
        diameter = 1;
        FindDiameter(root);
        
        return diameter -1;

    }
    
    public int FindDiameter(TreeNode root)
    {
        if(root == null) return 0;
        
        if(root.left == null && root.right == null) return 1;
        
        int left = FindDiameter(root.left);
        int right = FindDiameter(root.right);
        
        diameter = Math.Max(left+right+1, diameter);
        
        return Math.Max(left,right) + 1;
    }
	

  public class TreeNode {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
  }