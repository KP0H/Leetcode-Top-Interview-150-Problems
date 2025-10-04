func lengthOfLongestSubstring(s string) int {
    last := make(map[byte]int)
	best, start := 0, 0

	for i := 0; i < len(s); i++ {
		ch := s[i]
		if prev, ok := last[ch]; ok && prev >= start {
			start = prev + 1
		}
		last[ch] = i
		if cur := i - start + 1; cur > best {
			best = cur
		}
	}
	return best
}