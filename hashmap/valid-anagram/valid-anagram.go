func isAnagram(s string, t string) bool {
    if len(s) != len(t) {
        return false
    }
    var cnt [26]int
    for i := 0; i < len(s); i++ {
        cnt[s[i]-'a']++
        cnt[t[i]-'a']--
    }
    for _, v := range cnt[:] {
        if v != 0 {
            return false
        }
    }
    return true
}

func isAnagramUnicode(s string, t string) bool {
	if utf8.RuneCountInString(s) != utf8.RuneCountInString(t) {
        return false
    }

    m := make(map[rune]int, len(s))

    for _, r := range s {
        m[r]++
    }
    for _, r := range t {
        m[r]--
        if m[r] == 0 {
            delete(m, r)
        }
    }
    return len(m) == 0
}