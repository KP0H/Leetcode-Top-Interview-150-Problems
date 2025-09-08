/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func sortedArrayToBST(nums []int) *TreeNode {
    return build(nums, 0, len(nums)-1)
}

func build(a []int, lo, hi int) *TreeNode {
    if lo > hi {
        return nil
    }
    mid := lo + (hi-lo)/2
    node := &TreeNode{Val: a[mid]}
    node.Left = build(a, lo, mid-1)
    node.Right = build(a, mid+1, hi)
    return node
}