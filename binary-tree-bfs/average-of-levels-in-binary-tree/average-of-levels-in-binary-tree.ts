// Definition for a binary tree node.
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
 

function averageOfLevels(root: TreeNode | null): number[] {
    if (!root) return [];
    const result: number[] = [];
    const queue: TreeNode[] = [root];

    while (queue.length > 0)
    {
        const size = queue.length;
        let sum = 0;

        for (let i = 0; i < size; i++)
        {
            var treeNode = queue.shift()!;
            sum += treeNode.val;
            if (treeNode.left != null) { queue.push(treeNode.left); }
            if (treeNode.right != null) { queue.push(treeNode.right); }
        }

        result.push(sum / size);
    }
    return result;
};