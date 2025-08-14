function isPalindrome(s: string): boolean {
    if (!s) return false;

    const letterOrDigit = /[a-z0-9]/i;

    const isLetterOrDigit = (ch: string) => letterOrDigit.test(ch);

    for (let left = 0, right = s.length - 1; left < right; ) {
        while (left < right && !isLetterOrDigit(s[left])) left++;
        while (left < right && !isLetterOrDigit(s[right])) right--;

        if (s[left++].toLowerCase() !== s[right--].toLowerCase()) {
            return false;
        }
    }
    return true;
};