function isSubsequence(s: string, t: string): boolean {
    if (s.length == 0) return true;
    if (s.length > t.length) return false;

    for (let i = 0, j = 0; i <= t.length - 1; i++)
    {
        if (s[j] == t[i])
        {
            j++;
            if (j == s.length)
            {
                return true;
            }
        }
    }

    return false;
};