function hIndex(citations: number[]): number {
    const n = citations.length;
    const bucket = new Array<number>(n + 1).fill(0);

    for (const c of citations) {
        bucket[c >= n ? n : c]++;
    }

    let papers = 0;
    for (let h = n; h >= 0; h--) {
        papers += bucket[h];
        if (papers >= h) return h;
    }
    return 0;
};