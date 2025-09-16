func rotate(nums []int, k int)  {
    n := len(nums)
	if n <= 1 {
		return
	}
	k %= n
	if k == 0 {
		return
	}

	reverse(nums, 0, n-1)
	reverse(nums, 0, k-1)
	reverse(nums, k, n-1)
}

func reverse(a []int, l, r int) {
	for l < r {
		a[l], a[r] = a[r], a[l]
		l++
		r--
	}
}