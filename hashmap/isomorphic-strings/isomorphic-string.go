func isIsomorphic(s string, t string) bool {
    if len(s) == 1 {
		return true
	}

    dict := make(map[rune]rune)
    used := make(map[rune]bool)

    for i := 0; i < len(s); i++ {
        a := rune(s[i])
		b := rune(t[i])
		
        if dictedB, exist := dict[a]; exist {
            if dictedB != b {
				return false
			}
            continue;
        }

        if _, exist := used[b]; exist {
			return false
		}

        dict[a] = b;
        used[b] = true;
    }

    return true;
}