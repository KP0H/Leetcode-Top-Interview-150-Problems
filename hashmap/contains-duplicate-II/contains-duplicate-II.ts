function containsNearbyDuplicate(nums: number[], k: number): boolean {
    const lastIdx = new Map<number, number>();

    for (let i = 0; i < nums.length; i++){
        const v = nums[i];
        if (lastIdx.has(v)){
            const prev = lastIdx.get(v)!;
            if (i - prev <= k) return true;
        }
        lastIdx.set(v, i);
    }

    return false;
};

function containsNearbyDuplicateWindow(nums: number[], k: number): boolean {
    const window = new Set<number>();

    for (let i = 0; i < nums.length; i++){
        if (i > k) window.delete(nums[i - k - 1]);
        if (window.has(nums[i])) return true;
        window.add(nums[i]);
    }

    return false;
};