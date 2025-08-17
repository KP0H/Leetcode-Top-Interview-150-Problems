function summaryRanges(nums: number[]): string[] {
    const result: string[] = [];

    if (nums.length === 0) return result;

    let start = nums[0];

    for (let i = 1; i <= nums.length; i++)
    {
        if (i === nums.length || nums[i] !== nums[i - 1] + 1)
        {
            const end = nums[i - 1];
            result.push(start === end ? `${start}` : `${start}->${end}`);
            
            if (i < nums.length) start = nums[i];
        }
    }

    return result;
};