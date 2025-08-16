function majorityElement(nums: number[]): number {
    let count: number= 0;
    let candidate: number = 0;

    for (let num of nums)
    {
        if (count == 0)
        {
            candidate = num;
        }

        count += (candidate === num) ? 1 : -1;
    }

    return candidate;
};