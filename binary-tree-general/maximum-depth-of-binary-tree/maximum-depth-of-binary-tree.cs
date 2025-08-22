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
public class Solution
{
    public int MaxDepth(TreeNode root)
    {
        return MaxDepthViaQueue(root);
        //return MaxDepthViaStack(root);
        //return MaxDepthViaRecursion(root);
    }

    /// <summary>
    /// Time O(n), Space O(h)
    /// Simple
    /// Risk: Stack Overflow
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepthViaRecursion(TreeNode root)
    {
        if (root == null) return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }

    /// <summary>
    /// Time O(n), Space O(h)
    /// No call stack risk
    /// h usualy less than w
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepthViaStack(TreeNode root)
    {
        if (root == null) return 0;
        int maxDepth = 0;
        var stack = new Stack<(TreeNode, int depth)>();
        stack.Push((root, 1));

        while (stack.Count() > 0)
        {
            (TreeNode node, int depth) = stack.Pop();
            maxDepth = Math.Max(depth, maxDepth);
            if (node.left != null)
            {
                stack.Push((node.left, depth + 1));
            }
            if (node.right != null)
            {
                stack.Push((node.right, depth + 1));
            }
        }
        return maxDepth;
    }

    /// <summary>
    /// Time O(n), Space O(w)
    /// No call stack risk
    /// w usualy more than h
    /// </summary>
    /// <param name="root"></param>
    /// <returns></returns>
    public int MaxDepthViaQueue(TreeNode root)
    {
        if (root == null) return 0;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int depth = 0;

        while (queue.Count > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var node = queue.Dequeue();
                if (node.left != null) queue.Enqueue(node.left);
                if (node.right != null) queue.Enqueue(node.right);
            }
            depth++;
        }

        return depth;
    }
}