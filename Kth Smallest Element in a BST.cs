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
    public int KthSmallest(TreeNode root, int k) {
            List<int> list = new List<int>();
            AddInOrder(root, list);

            return list[k - 1];
    }
            private void AddInOrder(TreeNode root, List<int> values)
        {
            if (root == null)
                return;

            AddInOrder(root.left, values);
            values.Add(root.val);
            AddInOrder(root.right, values);
        }
}