func canJump(nums []int) bool {
    n := len(nums)
    farthest := 0
    for i := 0; i <= farthest && i < n; i++ {
        if i+nums[i] > farthest {
            farthest = i + nums[i]
        }
        if farthest >= n-1 {
            return true
        }
    }
    return n == 1
}