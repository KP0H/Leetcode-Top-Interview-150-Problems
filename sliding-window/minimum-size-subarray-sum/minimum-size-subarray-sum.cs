public class Solution
{
    public int MinSubArrayLen(int target, int[] nums)
    {
        int n = nums.Length;
        int left = 0, sum = 0, ans = int.MaxValue;

        for (int rigth = 0; rigth < n; rigth++)
        {
            sum += nums[rigth];

            while (sum >= target)
            {
                ans = Math.Min(ans, rigth - left + 1);
                sum -= nums[left++];
            }
        }

        return ans == int.MaxValue ? 0 : ans;
    }

    public int MinSubArrayLenWithPrefixes(int target, int[] nums)
    {
        int n = nums.Length;
        var pref = new int[n + 1];
        for (int i = 1; i <= n; i++) pref[i] = pref[i - 1] + nums[i - 1];

        int ans = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            int need = pref[i] + target;
            int j = LowerBound(pref, need);
            if (j != -1) ans = Math.Min(ans, j - i);
        }
        return ans == int.MaxValue ? 0 : ans;
    }

    private int LowerBound(int[] a, int x)
    {
        int l = 0, r = a.Length - 1, ans = -1;
        while (l <= r)
        {
            int m = l + ((r - l) >> 1);
            if (a[m] >= x) { ans = m; r = m - 1; }
            else l = m + 1;
        }
        return ans;
    }
}