public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> result = new List<string>();
        if (nums.Length == 0) return result;

        int start = nums[0];

        for (int i = 1; i <= nums.Length; i++)
        {
            if (i == nums.Length || nums[i] != nums[i - 1] + 1)
            {
                int end = nums[i - 1];
                result.Add(start == end ? $"{start}" : $"{start}->{end}");
                if (i < nums.Length)
                {
                    start = nums[i];
                }
            }
        }

        return result;
    }
}