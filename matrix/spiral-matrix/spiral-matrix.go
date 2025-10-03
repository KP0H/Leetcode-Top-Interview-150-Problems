func spiralOrder(matrix [][]int) []int {
    m, n := len(matrix), len(matrix[0])
	res := make([]int, 0, m*n)
	top, bottom := 0, m-1
	left, right := 0, n-1

	for top <= bottom && left <= right {
		for c := left; c <= right; c++ {
			res = append(res, matrix[top][c])
		}
		top++

		for r := top; r <= bottom; r++ {
			res = append(res, matrix[r][right])
		}
		right--

		if top <= bottom {
			for c := right; c >= left; c-- {
				res = append(res, matrix[bottom][c])
			}
			bottom--
		}
		if left <= right {
			for r := bottom; r >= top; r-- {
				res = append(res, matrix[r][left])
			}
			left++
		}
	}
	return res
}