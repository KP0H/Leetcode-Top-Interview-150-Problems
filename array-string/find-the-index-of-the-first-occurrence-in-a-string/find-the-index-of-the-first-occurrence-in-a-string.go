func strStr(haystack string, needle string) int {
    if len(needle) == 0 { return 0 }
    if len(needle) > len(haystack) { return -1 }

    for i := 0; i <= len(haystack) - len(needle); i++ {
        j := 0
        for j < len(needle) && haystack[i + j] == needle[j] { j++ }
        if j == len(needle) { return i }
    }
    return -1
}