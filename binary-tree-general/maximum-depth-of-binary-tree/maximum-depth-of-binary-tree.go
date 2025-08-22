/**
 * Definition for a binary tree node.
 * type TreeNode struct {
 *     Val int
 *     Left *TreeNode
 *     Right *TreeNode
 * }
 */
func maxDepth(root *TreeNode) int {
    return MaxDepthRecursive(root)
	//return MaxDepthStack(root)
	//return MaxDepthQueue(root)
}

// ---------------------------
// 1. DFS, Recursive
// ---------------------------
func MaxDepthDFS(root *TreeNode) int {
    if root == nil {
        return 0
    }
    left := MaxDepthDFS(root.Left)
    right := MaxDepthDFS(root.Right)
    if left > right {
        return left + 1
    }
    return right + 1
}

// ---------------------------
// 2. DFS, Stack, Iterations
// ---------------------------
func MaxDepthStack(root *TreeNode) int {
    if root == nil {
        return 0
    }
    maxDepth := 0
    stack := []struct {
        node  *TreeNode
        depth int
    }{{root, 1}}

    for len(stack) > 0 {
        n := len(stack) - 1
        item := stack[n]
        stack = stack[:n]

        if item.depth > maxDepth {
            maxDepth = item.depth
        }

        if item.node.Left != nil {
            stack = append(stack, struct {
                node  *TreeNode
                depth int
            }{item.node.Left, item.depth + 1})
        }
        if item.node.Right != nil {
            stack = append(stack, struct {
                node  *TreeNode
                depth int
            }{item.node.Right, item.depth + 1})
        }
    }

    return maxDepth
}

// ---------------------------
// 3. BFS, Queue, Iterations
// ---------------------------
func MaxDepthQueue(root *TreeNode) int {
    if root == nil {
        return 0
    }
    depth := 0
    queue := []*TreeNode{root}

    for len(queue) > 0 {
        size := len(queue)
        for i := 0; i < size; i++ {
            node := queue[0]
            queue = queue[1:]

            if node.Left != nil {
                queue = append(queue, node.Left)
            }
            if node.Right != nil {
                queue = append(queue, node.Right)
            }
        }
        depth++
    }

    return depth
}