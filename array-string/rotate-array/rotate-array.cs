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

    public void RotateExtraArray(int[] nums, int k)
    {
        int n = nums.Length;
        if (n <= 1) return;
        k %= n;
        if (k == 0) return;

        var tmp = new int[n];
        for (int i = 0; i < n; i++)
        {
            tmp[(i + k) % n] = nums[i];
        }
        Array.Copy(tmp, nums, n);
    }
    
    public void RotateCycle(int[] nums, int k) {
        int n = nums.Length;
        if (n <= 1) return;
        k %= n;
        if (k == 0) return;

        int moved = 0;
        for (int start = 0; moved < n; start++) {
            int curr = start;
            int prev = nums[start];
            do {
                int next = (curr + k) % n;
                (nums[next], prev) = (prev, nums[next]);
                curr = next;
                moved++;
            } while (curr != start);
        }
    }
}