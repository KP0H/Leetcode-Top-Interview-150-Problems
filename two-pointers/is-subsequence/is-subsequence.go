func isSubsequence(s string, t string) bool {
	if len(s) == 0 {
		return true
	}
	if len(s) > len(t) {
		return false;
	}

	i, j := 0, 0
	for (i <= len(t) - 1) {
		if s[j] == t[i] {
			j++;
			if j == len(s) {
				return true
			}
		}

		i++
	}

	return false
}