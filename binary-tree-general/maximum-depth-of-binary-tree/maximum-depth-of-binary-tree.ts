//Definition for a binary tree node.
class TreeNode {
    val: number
    left: TreeNode | null
    right: TreeNode | null
    constructor(val?: number, left?: TreeNode | null, right?: TreeNode | null) {
        this.val = (val===undefined ? 0 : val)
        this.left = (left===undefined ? null : left)
        this.right = (right===undefined ? null : right)
    }
}

function maxDepth(root: TreeNode | null): number {
    return maxDepthRecursive(root)
    //return maxDepthStack(root)
    //return maxDepthQueue(root)
};


// ---------------------------
// 1. DFS, Recursive
// ---------------------------
function maxDepthRecursive(root: TreeNode | null): number {
    if (!root) return 0;
    return 1 + Math.max(maxDepthRecursive(root.left), maxDepthRecursive(root.right));
}

// ---------------------------
// 2. DFS, Stack, Iterations
// ---------------------------
function maxDepthStack(root: TreeNode | null): number {
    if (!root) return 0;
    let maxDepth = 0;
    const stack: [TreeNode, number][] = [[root, 1]];

    while (stack.length > 0) {
        const [node, depth] = stack.pop()!;
        maxDepth = Math.max(maxDepth, depth);

        if (node.left) stack.push([node.left, depth + 1]);
        if (node.right) stack.push([node.right, depth + 1]);
    }

    return maxDepth;
}

// ---------------------------
// 3. BFS, Queue, Iterations
// ---------------------------
function maxDepthQueue(root: TreeNode | null): number {
    if (!root) return 0;
    let depth = 0;
    const queue: TreeNode[] = [root];

    while (queue.length > 0) {
        let size = queue.length;
        for (let i = 0; i < size; i++) {
            const node = queue.shift()!;
            if (node.left) queue.push(node.left);
            if (node.right) queue.push(node.right);
        }
        depth++;
    }

    return depth;
}