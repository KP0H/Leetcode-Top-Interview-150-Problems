function minSubArrayLen(target: number, nums: number[]): number {
    const n = nums.length;
    let left = 0, sum = 0, ans = Number.MAX_VALUE;

    for (let rigth = 0; rigth < n; rigth++)
    {
        sum += nums[rigth];

        while (sum >= target)
        {
            ans = Math.min(ans, rigth - left + 1);
            sum -= nums[left++];
        }
    }

    return ans == Number.MAX_VALUE ? 0 : ans;
};