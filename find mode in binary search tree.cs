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
    public int[] FindMode(TreeNode root) {
            if (root == null)
            {
                return new int[] { };
            }
            if (root.left == null && root.right == null)
            {
                return new int[] { root.val };
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);

            Dictionary<int, int> hash = new Dictionary<int, int>();
            //int count = 0;
            // Do level order traversal until we find  
            // an empty place.  
            while (q.Count != 0)
            {
                root = q.Peek();
                q.Dequeue();

                if (hash.ContainsKey(root.val))
                {
                    var val = hash[root.val];
                    val++;
                    hash[root.val] = val;
                }
                else
                {
                    hash.Add(root.val, 1);
                }
                if (root.left != null)
                {
                    q.Enqueue(root.left);
                }
                if (root.right != null)
                {
                    q.Enqueue(root.right);
                }
            }
            var max = hash.Values.Max();
            return hash.Where(x => x.Value == max).Select(x => x.Key).ToArray();
    }
}