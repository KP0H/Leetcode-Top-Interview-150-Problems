function longestCommonPrefix(strs: string[]): string {
    if (strs.length === 0) return "";

    let minLen = Math.min(...strs.map(s => s.length));
    let prefixLen = 0;

    for (let i = 0; i < minLen; i++) {
        const c = strs[0][i];
        for (let j = 1; j < strs.length; j++) {
            if (strs[j][i] !== c) {
                return strs[0].substring(0, prefixLen);
            }
        }
        prefixLen++;
    }

    return strs[0].substring(0, prefixLen);
};