function numIslands(grid: string[][]): number {
    const m = grid.length;
    const n = grid[0].length;
    let count = 0;

    const dirs = [[1,0], [-1,0], [0,1], [0,-1]];

    for (let r = 0; r < m; r++) {
        for (let c = 0; c < n; c++) {
            if (grid[r][c] !== "1") continue;
            count++;
            grid[r][c] = "0";
            const q: [number, number][] = [[r, c]];

            while (q.length > 0) {
                const [i, j] = q.shift()!;
                for (const [dr, dc] of dirs) {
                    const ni = i + dr, nj = j + dc;
                    if (ni < 0 || nj < 0 || ni >= m || nj >= n) continue;
                    if (grid[ni][nj] !== "1") continue;
                    grid[ni][nj] = "0";
                    q.push([ni, nj]);
                }
            }
        }
    }

    return count;
};