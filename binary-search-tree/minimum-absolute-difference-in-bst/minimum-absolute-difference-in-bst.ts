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

function getMinimumDifference(root: TreeNode | null): number {
    const stack: TreeNode[] = [];
    let curr: TreeNode | null = root;
    let prev: number | null = null;
    let min = Number.MAX_SAFE_INTEGER;

    while (curr || stack.length)
    {
        while (curr != null)
        {
            stack.push(curr);
            curr = curr.left;
        }

        curr = stack.pop()!;
        if (prev !== null)
            min = Math.min(min, curr.val - prev);
        prev = curr.val;

        curr = curr.right;
    }

    return min;
}

function getMinimumDifferenceMorris(root: TreeNode | null): number {
    let curr: TreeNode | null = root;
    let prevVal: number | null = null;
    let ans = Number.MAX_SAFE_INTEGER;

    while (curr) {
        if (!curr.left) {
            if (prevVal !== null) ans = Math.min(ans, curr.val - prevVal);
            prevVal = curr.val;
            curr = curr.right;
        } else {
            let pre = curr.left;
            while (pre!.right && pre!.right !== curr) pre = pre!.right;

            if (!pre!.right) {
                pre!.right = curr;
                curr = curr.left;
            } else {
                pre!.right = null;
                if (prevVal !== null) ans = Math.min(ans, curr.val - prevVal);
                prevVal = curr.val;
                curr = curr.right;
            }
        }
    }
    return ans;
};