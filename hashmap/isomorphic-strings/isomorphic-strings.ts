function isIsomorphic(s: string, t: string): boolean {
    if (s.length == 1) return true;

    const dict = new Map<string, string>();
    const used = new Set<string>();

    for (let i = 0; i < s.length; i++)
    {
        const a = s[i], b = t[i];

        if (dict.has(a))
        {
            if (dict.get(a)! !== b) return false
            continue;
        }

        if (used.has(b)) return false
        dict.set(a, b);
        used.add(b);
    }

    return true;
};