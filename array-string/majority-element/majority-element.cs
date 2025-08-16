public class Solution
{
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> maj = new Dictionary<int, int>();

        int majKey = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (maj.ContainsKey(nums[i]))
            {
                maj[nums[i]]++;
                if (nums[i] != majKey && maj[nums[i]] > maj[majKey])
                {
                    majKey = nums[i];
                }
            }
            else
            {
                maj.Add(nums[i], 1);
                if (majKey == 0)
                {
                    majKey = nums[i];
                }
            }
        }

        return majKey;
    }
}