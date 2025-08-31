function strStr(haystack: string, needle: string): number {
    if (needle.length == 0) return 0;
    if (needle.length > haystack.length) return -1;

    for (let i = 0; i <= haystack.length - needle.length; i++) {
        let j = 0;
        while (j < needle.length && haystack[i + j] == needle[j]) {
            j++;
        }
        if (j == needle.length) {
            return i;
        }
    }
    return -1;
};