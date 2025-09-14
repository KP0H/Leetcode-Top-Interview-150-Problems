func mySqrt(x int) int {
    if x < 2 {
		return x
	}
	lo, hi := 1, x/2
	ans := 0
	for lo <= hi {
		mid := lo + (hi-lo)/2
		if mid <= x/mid {
			ans = mid
			lo = mid + 1
		} else {
			hi = mid - 1
		}
	}
	return ans
}