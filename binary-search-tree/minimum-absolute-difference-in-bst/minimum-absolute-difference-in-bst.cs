/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public int GetMinimumDifference(TreeNode root)
    {
        var stack = new Stack<TreeNode>();
        var curr = root;
        int min = int.MaxValue;
        int? prev = null;

        while (curr != null || stack.Count > 0)
        {
            while (curr != null)
            {
                stack.Push(curr);
                curr = curr.left;
            }

            curr = stack.Pop();
            if (prev.HasValue)
                min = Math.Min(min, curr.val - prev.Value);
            prev = curr.val;

            curr = curr.right;
        }

        return min;
    }
}