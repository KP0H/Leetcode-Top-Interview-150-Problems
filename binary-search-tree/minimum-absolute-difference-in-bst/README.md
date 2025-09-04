Given the `root` of a Binary Search Tree (BST), return _the minimum absolute difference between the values of any two different nodes in the tree_.

#### Example 1:

![](/binary-search-tree/minimum-absolute-difference-in-bst/img/example1.png)

**Input:** root = [4,2,6,1,3]  
**Output:** 1

#### Example 2:

![](/binary-search-tree/minimum-absolute-difference-in-bst/img/example2.png)

**Input:** root = [1,0,48,null,null,12,49]  
**Output:** 1

#### Constraints:

- The number of nodes in the tree is in the range `[2, 10⁴]`.
- `0 <= Node.val <= 10⁵`

#### Solutions:

- [C#](/binary-search-tree/minimum-absolute-difference-in-bst/minimum-absolute-difference-in-bst.cs)
- [TypeScript](/binary-search-tree/minimum-absolute-difference-in-bst/minimum-absolute-difference-in-bst.ts)
- [Go](/binary-search-tree/minimum-absolute-difference-in-bst/minimum-absolute-difference-in-bst.go)

Complexity
- Time O(n)
- Space O(h) / O(1) fir Morris traversal

**Note:** This question is the same as 783: [https://leetcode.com/problems/minimum-distance-between-bst-nodes/](https://leetcode.com/problems/minimum-distance-between-bst-nodes/)