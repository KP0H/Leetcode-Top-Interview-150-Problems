Given two strings `s` and `t`, return `true` _if `s` is a **subsequence** of_ `t`, or `false` _otherwise_.

A **subsequence** of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., `"ace"` is a subsequence of `"abcde"` while "aec" is not).

 

#### Example 1:

> **Input:** s = "abc", t = "ahbgdc"  
> **Output:** true

####Example 2:

> **Input:** s = "axc", t = "ahbgdc"  
> **Output:** false
 

#### Constraints:

- `0 <= s.length <= 100`
- `0 <= t.length <= 104`
- `s` and `t` consist only of lowercase English letters.


#### Solutions:

- [C#](/two-pointers/is-subsequence/is-subsequence.cs)
- [TypeScript](/two-pointers/is-subsequence/is-subsequence.ts)
- [Go](/two-pointers/is-subsequence/is-subsequence.go)

#### Complexity
- Time O(n) - we check each element once
- Space O(1) - no extra arrays, just a counter 

**Follow up:** Suppose there are lots of incoming `s`, say `s1, s2, ..., sk` where `k >= 10⁹`, and you want to check one by one to see if `t` has its subsequence. In this scenario, how would you change your code?'

Idea: _Dictionary or Jump-Table_