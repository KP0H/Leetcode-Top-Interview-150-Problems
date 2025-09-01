function minSubArrayLen(target: number, nums: number[]): number {
    const n = nums.length;
    let left = 0, sum = 0, ans = Number.MAX_VALUE;

    for (let rigth = 0; rigth < n; rigth++)
    {
        sum += nums[rigth];

        while (sum >= target)
        {
            ans = Math.min(ans, rigth - left + 1);
            sum -= nums[left++];
        }
    }

    return ans == Number.MAX_VALUE ? 0 : ans;
};

function MinSubArrayLenWithPrefixes(target: number, nums: number[]): number {
    const n = nums.length;
    const pref = new Array<number>(n + 1);
    pref[0] = 0;
    for (let i = 1; i <= n; i++) pref[i] = pref[i - 1] + nums[i - 1];

    let ans = Number.MAX_VALUE;

    for (let l = 0; l < n; l++) {
        const need = pref[l] + target;
        const j = lowerBound(pref, need);
        if (j !== -1) ans = Math.min(ans, j - l);
    }
    return ans === Number.MAX_VALUE ? 0 : ans;
};

function lowerBound(a: number[], x: number): number {
    let l = 0, r = a.length - 1, res = -1;
    while (l <= r) {
        const m = l + ((r - l) >> 1);
        if (a[m] >= x) { res = m; r = m - 1; }
        else l = m + 1;
    }
    return res;
}