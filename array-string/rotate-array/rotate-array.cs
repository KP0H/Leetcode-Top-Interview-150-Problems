public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        if (n <= 1) return;
        k %= n;
        if (k == 0) return;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    private void Reverse(int[] a, int l, int r)
    {
        while (l < r)
        {
            (a[l], a[r]) = (a[r], a[l]);
            l++; r--;
        }
    }
}