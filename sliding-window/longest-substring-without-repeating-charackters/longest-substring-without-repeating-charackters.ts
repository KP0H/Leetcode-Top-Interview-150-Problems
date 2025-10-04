function lengthOfLongestSubstring(s: string): number {
    const last = new Map<string, number>();
    let best = 0, start = 0;

    for (let i = 0; i < s.length; i++) {
        const ch = s[i];
        const prev = last.get(ch);
        if (prev !== undefined && prev >= start) {
            start = prev + 1;
        }
        last.set(ch, i);
        if (i - start + 1 > best) best = i - start + 1;
    }
    return best;
}
