function twoSum(nums: number[], target: number): number[] {
    const map: Map<number, number> = new Map();

    for (let i = 0; i < nums.length; i++)
    {
        const complement = target - nums[i];
        if (map.has(complement))
        {
            return [i, map.get(complement)!];
        }

        if (!map.has(nums[i]))
        {
            map.set(nums[i],  i);
        }
    }

    return [];
};