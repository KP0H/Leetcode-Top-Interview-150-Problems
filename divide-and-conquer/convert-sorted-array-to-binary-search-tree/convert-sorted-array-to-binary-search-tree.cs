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
    public TreeNode SortedArrayToBST(int[] nums)
    {
        return Build(nums, 0, nums.Length - 1);
    }
    
    private TreeNode Build(int[] a, int lo, int hi)
    {
        if (lo > hi) return null;

        int mid = lo + ((hi - lo) >> 1);
        var node = new TreeNode(a[mid]);

        node.left  = Build(a, lo, mid - 1);
        node.right = Build(a, mid + 1, hi);

        return node;
    }
}