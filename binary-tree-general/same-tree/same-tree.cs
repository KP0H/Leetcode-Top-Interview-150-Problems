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
    public bool IsSameTree(TreeNode p, TreeNode q)
    {
        if (p == null && q == null) return true;

        if (p == null || q == null)
        {
            return false;
        }

        if (p.val != q.val) return false;

        return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
    }

    public bool IsSameTreeStack(TreeNode p, TreeNode q)
    {
        var stack = new Stack<(TreeNode, TreeNode)>();
        stack.Push((p, q));

        while (stack.Count > 0)
        {
            var (a, b) = stack.Pop();

            if (a == null && b == null) continue;
            if (a == null || b == null) return false;
            if (a.val != b.val) return false;

            stack.Push((a.left, b.left));
            stack.Push((a.right, b.right));
        }

        return true;
    }

    public bool IsSameTreeQueue(TreeNode p, TreeNode q)
    {
        var queue = new Queue<(TreeNode, TreeNode)>();
        queue.Enqueue((p, q));

        while (queue.Count > 0)
        {
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var (a, b) = queue.Dequeue();

                if (a == null && b == null) continue;
                if (a == null || b == null) return false;
                if (a.val != b.val) return false;

                queue.Enqueue((a.left, b.left));
                queue.Enqueue((async.right, b.right));
            }
        }

        return true;
    }
}