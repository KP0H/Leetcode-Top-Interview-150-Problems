func summaryRanges(nums []int) []string {
    if len(nums) == 0 {
        return nil
    }

	var result []string
    start := nums[0]

    for i := 1; i <= len(nums); i++ {
        if i == len(nums) || nums[i] != nums[i - 1] + 1 {
            end := nums[i - 1]
			if start == end {
				result = append(result, strconv.Itoa(start))
			} else {
				result = append(result, fmt.Sprintf("%d->%d",start,end))
			}            
            
            if i < len(nums) {
				start = nums[i]
			}
        }
    }

    return result;
}