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

func rotateExtraArray(nums []int, k int) {
	n := len(nums)
	if n <= 1 {
		return
	}
	k %= n
	if k == 0 {
		return
	}

	tmp := make([]int, n)
	for i := 0; i < n; i++ {
		tmp[(i+k)%n] = nums[i]
	}
	copy(nums, tmp)
}

func rotateCycles(nums []int, k int) {
	n := len(nums)
	if n <= 1 {
		return
	}
	k %= n
	if k == 0 {
		return
	}

	moved := 0
	for start := 0; moved < n; start++ {
		curr := start
		prev := nums[start]
		for {
			next := (curr + k) % n
			nums[next], prev = prev, nums[next]
			curr = next
			moved++
			if curr == start {
				break
			}
		}
	}
}
