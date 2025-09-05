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

function invertTreeDfs(root: TreeNode | null): TreeNode | null {
    if (!root) return null;

    const left = invertTreeDfs(root.left);
    const right = invertTreeDfs(root.right);

    root.left = right;
    root.right = left;

    return root;
};

function invertTreeBfsQueue(root: TreeNode | null): TreeNode | null {
    if (!root) return null;

    const queue: TreeNode[] = [root];

    while (queue.length > 0) {
        const node = queue.shift()!;

        [node.left, node.right] = [node.right, node.left];

        if (node.left) queue.push(node.left);
        if (node.right) queue.push(node.right);
    }

    return root;
}