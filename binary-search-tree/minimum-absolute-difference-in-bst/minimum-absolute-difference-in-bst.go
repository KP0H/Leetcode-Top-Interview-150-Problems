/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func getMinimumDifference(root *TreeNode) int {
    stack := []*TreeNode{}
    curr := root
    var prev *int
    min := math.MaxInt

    for curr != nil || len(stack) > 0 {
        for curr != nil {
            stack = append(stack, curr)
            curr = curr.Left
        }
        n := len(stack) - 1
        curr = stack[n]
        stack = stack[:n]

        if prev != nil {
            if d := curr.Val - *prev; d < min {
                min = d
            }
        }
        v := curr.Val
        prev = &v

        curr = curr.Right
    }

    return min
}

func getMinimumDifferenceMorris(root *TreeNode) int {
	curr := root
	var prev *int
	min := math.MaxInt

	for curr != nil {
		if curr.Left == nil {
			if prev != nil {
				if d := curr.Val - *prev; d < min {
					min = d
				}
			}
			v := curr.Val
			prev = &v
			curr = curr.Right
		} else {
			pre := curr.Left
			for pre.Right != nil && pre.Right != curr {
				pre = pre.Right
			}
			if pre.Right == nil {
				pre.Right = curr
				curr = curr.Left
			} else {
				pre.Right = nil
				if prev != nil {
					if d := curr.Val - *prev; d < min {
						min = d
					}
				}
				v := curr.Val
				prev = &v
				curr = curr.Right
			}
		}
	}
	return min
}