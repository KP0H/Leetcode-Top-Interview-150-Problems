Given two strings `s` and `t`, return `true` if `t` is an anagram of `s`, and `false` otherwise.

**Example 1:**

**Input:** s = "anagram", t = "nagaram"
**Output:** true

**Example 2:**

**Input:** s = "rat", t = "car"
**Output:** false

**Constraints:**

- `1 <= s.length, t.length <= 5 * 104`
- `s` and `t` consist of lowercase English letters.

**Follow up:** What if the inputs contain Unicode characters? How would you adapt your solution to such a case?

 **Solutions:**

 - [C#](/hashmap/valid-anagram/valid-anagram.cs)
 - [TypeScript](/hashmap/valid-anagram/valid-anagram.ts)
 - [Go](/hashmap/valid-anagram/valid-anagram.go)

Complexity
- Time O(n)
- Space O(1) with array, O(k) k - unique symbols with dict