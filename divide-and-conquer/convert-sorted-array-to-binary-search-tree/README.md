Given an integer array `nums` where the elements are sorted in **ascending order**, convert _it to a_ **_height-balanced_** _binary search tree_.

**Example 1:**

![](/divide-and-conquer/convert-sorted-array-to-binary-search-tree/img/btree1.png)

> **Input:** nums = [-10,-3,0,5,9]  
> **Output:** [0,-3,9,-10,null,5]  
> **Explanation:** [0,-10,5,null,-3,null,9] is also accepted:  
> ![](/divide-and-conquer/convert-sorted-array-to-binary-search-tree/img/btree2.png)

**Example 2:**

![](/divide-and-conquer/convert-sorted-array-to-binary-search-tree/img/btree3.png)

> **Input:** nums = [1,3]  
> **Output:** [3,1]  
> **Explanation:** [1,null,3] and [3,1] are both height-balanced BSTs.

**Constraints:**

- `1 <= nums.length <= 104`
- `-104 <= nums[i] <= 104`
- `nums` is sorted in a **strictly increasing** order.

**Solutions:**

- [C#](/divide-and-conquer/convert-sorted-array-to-binary-search-tree/convert-sorted-array-to-binary-search-tree.cs)
- [TypeScript](/divide-and-conquer/convert-sorted-array-to-binary-search-tree/convert-sorted-array-to-binary-search-tree.ts)
- [Go](/divide-and-conquer/convert-sorted-array-to-binary-search-tree/convert-sorted-array-to-binary-search-tree.go)

Complexity
- Time O(n)
- Space O(log n)