func isValidSudoku(board [][]byte) bool {
    rows := make([]int, 9)
	cols := make([]int, 9)
	box  := make([]int, 9)

	for r := 0; r < 9; r++ {
		for c := 0; c < 9; c++ {
			ch := board[r][c]
			if ch == '.' {
				continue
			}
			bit := 1 << (int(ch) - int('1'))
			b := (r/3)*3 + (c/3)

			if (rows[r]&bit) != 0 || (cols[c]&bit) != 0 || (box[b]&bit) != 0 {
				return false
			}
			rows[r] |= bit
			cols[c] |= bit
			box[b]  |= bit
		}
	}
	return true
}