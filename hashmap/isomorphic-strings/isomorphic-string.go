func isIsomorphic(s string, t string) bool {
    if len(s) == 1 {
		return true
	}

    dict := make(map[rune]rune)
    used := make(map[rune]bool)

	tRunes := []rune(t)
    sRunes := []rune(s)

    for i, a := range sRunes {
		b := tRunes[i]
		
        if mapped, exist := dict[a]; exist {
            if mapped != b {
				return false
			}
            continue;
        }

        if used[b] {
			return false
		}

        dict[a] = b;
        used[b] = true;
    }

    return true;
}