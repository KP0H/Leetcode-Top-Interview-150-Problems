func longestConsecutive(nums []int) int {
    if len(nums) == 0 {
		return 0
	}
	set := make(map[int]struct{}, len(nums))
	for _, v := range nums {
		set[v] = struct{}{}
	}

	best := 0
	for x := range set {
		if _, ok := set[x-1]; !ok {
			y, lenSeq := x, 1
			for {
				if _, ok := set[y+1]; !ok {
					break
				}
				y++
				lenSeq++
			}
			if lenSeq > best {
				best = lenSeq
			}
		}
	}
	return best
}