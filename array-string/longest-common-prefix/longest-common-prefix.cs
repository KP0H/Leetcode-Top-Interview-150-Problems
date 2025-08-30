public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs == null || strs.Length == 0) return "";

        int minLen = int.MaxValue;
        foreach (var s in strs)
            minLen = Math.Min(minLen, s.Length);

        int prefixLen = 0;

        for (int i = 0; i < minLen; i++) {
            char c = strs[0][i];
            for (int j = 1; j < strs.Length; j++) {
                if (strs[j][i] != c) {
                    return strs[0].Substring(0, prefixLen);
                }
            }
            prefixLen++;
        }

        return strs[0].Substring(0, prefixLen);
    }
}