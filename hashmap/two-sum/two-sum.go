func twoSum(nums []int, target int) []int {
    m := make(map[int]int, len(nums))

    for i := 0; i < len(nums); i++ {
        diff := target - nums[i]

		if index, exists := m[diff]; exists {
            return []int{i, index}
        }

		m[nums[i]] = i
    }

    return nil
}