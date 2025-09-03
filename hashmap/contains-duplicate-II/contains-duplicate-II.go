func containsNearbyDuplicate(nums []int, k int) bool {
    last := make(map[int]int, len(nums))

	for i,v := range nums {
		if prev, ok := last[v]; ok && i-prev <= k {
			return true
		}
		last[v] = i
	}

	return false
}

func containsNearbyDuplicateWindow(nums []int, k int) bool {
    window := make(map[int]struct{})

	for i,v := range nums {
		if i > k {
			delete(window, nums[i-k-1])
		}
		if _, ok := window[v]; ok {
			return true
		}
		window[v] = struct{}{}
	}

	return false
}