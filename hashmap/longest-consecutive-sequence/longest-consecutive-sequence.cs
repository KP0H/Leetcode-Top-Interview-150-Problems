public class Solution
{
    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length == 0) return 0;

        var set = new HashSet<int>(nums);
        int best = 0;

        foreach (int x in set)
        {
            if (!set.Contains(x - 1))
            {
                int y = x, len = 1;
                while (set.Contains(y + 1)) { y++; len++; }
                if (len > best) best = len;
            }
        }
        return best;
    }
}