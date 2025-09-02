Given the `root` of a binary tree, return _the average value of the nodes on each level in the form of an array_. Answers within `10-5` of the actual answer will be accepted.

#### Example 1:

![](/binary-tree-bfs/average-of-levels-in-binary-tree/img/example1.png)

> **Input:** root = [3,9,20,null,null,15,7]  
> **Output:** [3.00000,14.50000,11.00000]  
> Explanation: The average value of nodes on level 0 is 3, on level 1 is 14.5, and on level 2 is 11.  
> Hence return [3, 14.5, 11].

#### Example 2:

![](/binary-tree-bfs/average-of-levels-in-binary-tree/img/example2.png)

> **Input:** root = [3,9,20,15,7]  
> **Output:** [3.00000,14.50000,11.00000]

#### Constraints:

- The number of nodes in the tree is in the range `[1, 104]`.
- `-231 <= Node.val <= 231 - 1`

 #### Solutions:

 - [C#](/binary-tree-bfs/average-of-levels-in-binary-tree/average-of-levels-in-binary-tree.cs)
 - [TypeScript](/binary-tree-bfs/average-of-levels-in-binary-tree/average-of-levels-in-binary-tree.ts)
 - [Go](/binary-tree-bfs/average-of-levels-in-binary-tree/average-of-levels-in-binary-tree.go)

Complexity
- Time O(n)
- Space O(w)