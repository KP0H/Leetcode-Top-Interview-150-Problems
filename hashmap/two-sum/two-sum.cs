public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
            {
                return [i, dict[target - nums[i]][0]];
            }

            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]].Add(i);
            }
            else
            {
                dict.Add(nums[i], new List<int> { i });
            }
        }
        return null;
    }
}