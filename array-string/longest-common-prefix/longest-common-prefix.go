func longestCommonPrefix(strs []string) string {
    if len(strs) == 0 {
        return ""
    }

    minLen := len(strs[0])
    for _, s := range strs {
        if len(s) < minLen {
            minLen = len(s)
        }
    }

    prefixLen := 0
    for i := 0; i < minLen; i++ {
        c := strs[0][i]
        for j := 1; j < len(strs); j++ {
            if strs[j][i] != c {
                return strs[0][:prefixLen]
            }
        }
        prefixLen++
    }

    return strs[0][:prefixLen]
}