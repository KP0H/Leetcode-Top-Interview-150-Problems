function wordPattern(pattern: string, s: string): boolean {
    var words = s.split(' ');

    if (pattern.length != words.length) return false;

    var p2w = new Map<string, string>();
    var w2p = new Map<string, string>();

    for (let i = 0; i < pattern.length; i++)
    {
        const p = pattern[i];
        const w = words[i];

        if (p2w.has(p))
        {
            if (p2w.get(p) != w) return false;
        }
        else
        {
            if (w2p.has(w) && w2p.get(w) != p) return false;
            p2w.set(p, w);
            w2p.set(w, p);
        }
    }

    return true;
};