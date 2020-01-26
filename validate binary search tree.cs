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
    public bool IsValidBST(TreeNode root) {
        var result = IsBst(root, int.MinValue, int.MaxValue);
        return result;
    }
        private bool IsBst(TreeNode node, int minVal, int maxVal)
        {
            if (node == null)
            {
                return true;
            }
            if (node.left != null && node.val == node.left.val)
            {
                return false;
            }
            if (node.right != null && node.val == node.right.val)
            {
                return false;
            }
            if (node.val < minVal || node.val > maxVal)
            {
                return false;
            }
            return IsBst(node.left, minVal, node.val == int.MinValue ? node.val : node.val - 1) &&
                IsBst(node.right, node.val == int.MaxValue ? node.val : node.val + 1, maxVal);
        }
}