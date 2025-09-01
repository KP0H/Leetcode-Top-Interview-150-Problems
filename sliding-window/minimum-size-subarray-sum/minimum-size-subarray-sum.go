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

func minSubArrayLenWithPrefixes(target int, nums []int) int {
    n := len(nums)
    pref := make([]int, n+1)
    for i := 1; i <= n; i++ {
        pref[i] = pref[i-1] + nums[i-1]
    }

    ans := math.MaxInt32
    for l := 0; l < n; l++ {
        need := pref[l] + target
        j := lowerBound(pref, need)
        if j != -1 {
            if curr := j - l; curr < ans {
                ans = curr
            }
        }
    }

    if ans == math.MaxInt32 {
        return 0
    }
    return ans
}

func lowerBound(a []int, x int) int {
    l, r := 0, len(a)-1
    res := -1
    for l <= r {
        m := l + (r-l)/2
        if a[m] >= x {
            res = m
            r = m - 1
        } else {
            l = m + 1
        }
    }
    return res
}