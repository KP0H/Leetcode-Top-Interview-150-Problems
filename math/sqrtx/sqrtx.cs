public class Solution {
    public int MySqrt(int x) {
        if (x < 2) return x;

        int lo = 1, hi = x / 2;
        int ans = 0;

        while (lo <= hi) {
            long mid = lo + (hi - lo) / 2;
            long sq = mid * mid;

            if (sq == x) return (int)mid;
            if (sq < x) {
                ans = (int)mid;
                lo = (int)mid + 1;
            } else {
                hi = (int)mid - 1;
            }
        }

        return ans;
    }
}