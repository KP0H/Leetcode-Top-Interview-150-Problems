func canConstruct(ransomNote string, magazine string) bool {
    counts := make([]int, 26)

	for i := 0; i < len(magazine); i++{
		counts[magazine[i] - 'a']++
	}

	for i := 0; i < len(ransomNote); i++ {
		j := ransomNote[i] - 'a'
		counts[j]--
		if counts[j] < 0 {
			return false
		}
	}

	return true
}