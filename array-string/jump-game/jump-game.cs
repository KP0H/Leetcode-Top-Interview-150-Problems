public class Solution
{
    public bool CanJump(int[] nums)
    {
        int n = nums.Length;
        int farthest = 0;
        for (int i = 0; i <= farthest && i < n; i++)
        {
            farthest = Math.Max(farthest, i + nums[i]);
            if (farthest >= n - 1) return true;
        }
        return n == 1;
    }
}