public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dict.ContainsKey(complement))
            {
                return [i, dict[complement]];
            }

            if (!dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;
            }
        }

        return null;
    }
}