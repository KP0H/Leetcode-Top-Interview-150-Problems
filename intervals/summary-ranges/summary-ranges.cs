public class Solution
{
    public IList<string> SummaryRanges(int[] nums)
    {
        List<string> result = new List<string>();
        if (nums.Length == 0) return result;
        int rangeStart, rangeEnd;
        rangeStart = rangeEnd = nums[0];

        int nextInRange = rangeStart + 1;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nextInRange)
            {
                nextInRange++;
                continue;
            }

            rangeEnd = nums[i - 1];

            if (rangeStart == rangeEnd)
            {
                result.Add($"{rangeStart}");
            }
            else
            {
                result.Add($"{rangeStart}->{rangeEnd}");
            }

            rangeStart = rangeEnd = nums[i];
            nextInRange = rangeStart + 1;
        }

        rangeEnd = nums[nums.Length - 1];
        if (rangeStart == rangeEnd)
        {
            result.Add($"{rangeStart}");
        }
        else
        {
            result.Add($"{rangeStart}->{rangeEnd}");
        }

        return result;
    }
}