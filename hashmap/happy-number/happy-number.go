func isHappy(n int) bool {
    slow, fast := n, n
    for {
        slow = sumSquares(slow)
        fast = sumSquares(sumSquares(fast))
        if slow == fast {
            return slow == 1
        }
    }
}

func sumSquares(x int) int {
    s := 0
    for x > 0 {
        d := x % 10
        s += d * d
        x /= 10
    }
    return s
}