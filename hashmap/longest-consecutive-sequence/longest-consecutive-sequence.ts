function longestConsecutive(nums: number[]): number {
    if (nums.length === 0) return 0;

    const set = new Set(nums);
    let best = 0;

    for (const x of set) {
        if (!set.has(x - 1)) {
            let y = x, len = 1;
            while (set.has(y + 1)) { y++; len++; }
            if (len > best) best = len;
        }
    }
    return best;
};