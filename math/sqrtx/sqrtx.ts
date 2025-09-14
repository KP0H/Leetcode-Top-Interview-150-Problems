function mySqrt(x: number): number {
    if (x < 2) return x;

    let lo = 1, hi = Math.floor(x / 2), ans = 0

    while (lo <= hi) {
        const mid = lo + Math.floor((hi - lo) / 2);
        const sq = mid * mid;

        if (sq === x) return mid;
        if (sq < x) {
            ans = mid;
            lo = mid + 1;
        } else {
            hi = mid - 1;
        }
    }

    return ans;
};