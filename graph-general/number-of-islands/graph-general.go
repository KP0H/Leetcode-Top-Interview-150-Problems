func numIslands(grid [][]byte) int {
    m, n := len(grid), len(grid[0])
    count := 0
    dirs := [][2]int{{1,0}, {-1,0}, {0,1}, {0,-1}}

    for r := 0; r < m; r++ {
        for c := 0; c < n; c++ {
            if grid[r][c] != '1' {
                continue
            }
            count++
            grid[r][c] = '0'
            q := [][2]int{{r, c}}

            for len(q) > 0 {
                cell := q[0]
                q = q[1:]
                i, j := cell[0], cell[1]

                for _, d := range dirs {
                    ni, nj := i+d[0], j+d[1]
                    if ni < 0 || nj < 0 || ni >= m || nj >= n {
                        continue
                    }
                    if grid[ni][nj] != '1' {
                        continue
                    }
                    grid[ni][nj] = '0'
                    q = append(q, [2]int{ni, nj})
                }
            }
        }
    }

    return count    
}