/**
 * Definition for a binary tree node.
 * class TreeNode {
 *     val: number
 *     left: TreeNode | null
 *     right: TreeNode | null
 *     constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
 *         this.val = (val===undefined ? 0 : val)
 *         this.left = (left===undefined ? null : left)
 *         this.right = (right===undefined ? null : right)
 *     }
 * }
 */

function sortedArrayToBST(nums: number[]): TreeNode | null {
    return build(nums, 0, nums.length - 1);
};

function build(a: number[], lo: number, hi: number): TreeNode | null {
    if (lo > hi) return null;
    const mid = lo + ((hi - lo) >> 1);
    const node = new TreeNode(a[mid]);
    node.left = build(a, lo, mid - 1);
    node.right = build(a, mid + 1, hi);
    return node;
}