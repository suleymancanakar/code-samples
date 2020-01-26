/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public bool IsSymmetric(TreeNode root) {
        
      if (root == null)
      {
    	  	return true;
      }
      
      return hasSymmetry (root.left,root.right);
    }    
    public bool hasSymmetry(TreeNode T1, TreeNode T2)
    {
    		if (T1 == null && T2 == null)
    		{
    			return true;
    		}
    		
    		if (T1 == null || T2 == null)
    		{
    			return false;
    		}
    		
    		if (T1.val == T2.val)
    		{
    			if (hasSymmetry(T1.right,T2.left) && hasSymmetry(T1.left,T2.right))
    			{
    				return true;
    			}
    		}
    		
    		return false;
    }
}