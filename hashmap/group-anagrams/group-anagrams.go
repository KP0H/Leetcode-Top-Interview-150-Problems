func groupAnagrams(strs []string) [][]string {
    m := make(map[string][]string)
	for _, s := range strs {
		key := sortString(s)
		m[key] = append(m[key], s)
	}
	res := make([][]string, 0, len(m))
	for _, v := range m {
		res = append(res, v)
	}
	return res
}

func sortString(s string) string {
	r := []rune(s)
	sort.Slice(r, func(i, j int) bool { return r[i] < r[j] })
	return string(r)
}
