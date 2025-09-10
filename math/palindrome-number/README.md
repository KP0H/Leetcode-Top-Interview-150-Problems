Given an integer `x`, return `true` _if_ `x` _is a_ _**palindrome**__, and_ `false` _otherwise_.

**Example 1:**

> **Input:** x = 121  
> **Output:** true  
> **Explanation:** 121 reads as 121 from left to right and from right to left.

**Example 2:**

> **Input:** x = -121  
> **Output:** false  
> **Explanation:** From left to right, it reads -121. From right to left, it becomes 121-. Therefore it is not a palindrome.

**Example 3:**

> **Input:** x = 10  
> **Output:** false  
> **Explanation:** Reads 01 from right to left. Therefore it is not a palindrome.

**Constraints:**

- `-231 <= x <= 231 - 1`

 **Solutions:**

 - [C#](/math/palindrome-number/palindrome-number.cs)
 - [TypeScript](/math/palindrome-number/palindrome-numbers.ts)
 - [Go](/math/palindrome-number/palindrome-numbers.go)

Complexity
- Time O(log₁₀ n) - half of digits
- Space O(1) - constant memory

**Follow up:** Could you solve it without converting the integer to a string?