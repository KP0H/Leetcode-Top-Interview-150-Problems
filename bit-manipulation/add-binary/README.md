Given two binary strings `a` and `b`, return _their sum as a binary string_.

**Example 1:**

> **Input:** a = "11", b = "1"  
> **Output:** "100"

**Example 2:**

> **Input:** a = "1010", b = "1011"  
> **Output:** "10101"

**Constraints:**

- `1 <= a.length, b.length <= 104`
- `a` and `b` consist only of `'0'` or `'1'` characters.
- Each string does not contain leading zeros except for the zero itself.

 **Solutions:**

 - [C#](/bit-manipulation/add-binary/add-binary.cs)
 - [TypeScript](/bit-manipulation/add-binary/add-binary.ts)
 - [Go](/bit-manipulation/add-binary/add-binary.go)

Complexity
- Time O(max(len(a), len(b)))
- Space O(max(len(a), len(b)) + 1)