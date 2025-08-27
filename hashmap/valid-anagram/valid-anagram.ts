function isAnagram(s: string, t: string): boolean {
    if (s.length !== t.length) return false;
    const cnt = new Array(26).fill(0);

    for (let i = 0; i < s.length; i++) {
        cnt[s.charCodeAt(i) - 97]++;   // 'a' = 97
        cnt[t.charCodeAt(i) - 97]--;
    }
    return cnt.every(x => x === 0);
};

function isAnagramUnicode(s: string, t: string): boolean{
    const map = new Map<string, number>();

    for (const ch of s) map.set(ch, (map.get(ch) ?? 0) + 1);
    for (const ch of t) map.set(ch, (map.get(ch) ?? 0) - 1);

    for (const v of map.values()) if (v !== 0) return false;
    return true;
}