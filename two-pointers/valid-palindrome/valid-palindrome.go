func isPalindrome(s string) bool {
    if len(s) == 0 {
        return false
    }

    left, right := 0, len(s)-1

    for left < right {
		lRune := rune(s[left])
        if (!unicode.IsLetter(lRune) && !unicode.IsDigit(lRune)) {
            left++
			continue
        }

		rRune := rune(s[right])
        if (!unicode.IsLetter(rRune) && !unicode.IsDigit(rRune)) {
            right--
			continue
        }

        if unicode.ToLower(lRune) != unicode.ToLower(rRune) {
            return false
        }

        left++
        right--
    }

    return true
}