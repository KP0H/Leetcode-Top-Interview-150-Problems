public class Solution {
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
}