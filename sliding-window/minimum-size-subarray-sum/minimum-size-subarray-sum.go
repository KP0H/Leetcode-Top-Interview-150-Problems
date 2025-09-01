func minSubArrayLen(target int, nums []int) int {
    n := len(nums)
    left := 0
    sum := 0
    ans := math.MaxInt32

    for rigth := 0; rigth < n; rigth++ {
        sum += nums[rigth]

        for sum >= target {
            ans = min(ans, rigth - left + 1)
            sum -= nums[left]
            left++
        }
    }

    if ans == math.MaxInt32 { 
        return 0
    } else { 
        return ans 
    }
}