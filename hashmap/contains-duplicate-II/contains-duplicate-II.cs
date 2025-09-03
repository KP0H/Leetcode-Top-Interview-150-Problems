public class Solution
{
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        var lastIdx = new Dictionary<int, int>(capacity: nums.Length);

        for (int i = 0; i < nums.Length; i++)
        {
            int val = nums[i];

            if (lastIdx.TryGetValue(val, out int prev))
            {
                if (i - prev <= k) return true;
            }
            lastIdx[val] = i;
        }

        return false;
    }
    
    public bool ContainsNearbyDuplicateWindow(int[] nums, int k)
    {
        var window = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (window.Contains(nums[i])) return true;

            window.Add(nums[i]);
            if (window.Count > k)
            {
                window.Remove(nums[i - k]);
            }
        }

        return false;
    }
}