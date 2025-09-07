public class Solution {
    public int NumIslands(char[][] grid) {
        int m = grid.Length;
        int n = grid[0].Length;
        int islands = 0;

        var dirs = new (int dr, int dc)[] { (1,0), (-1,0), (0,1), (0,-1) };
        var q = new Queue<(int r, int c)>();

        for (int r = 0; r < m; r++)
        {
            for (int c = 0; c < n; c++)
            {
                if (grid[r][c] != '1') continue;

                islands++;
                grid[r][c] = '0';
                q.Clear();
                q.Enqueue((r, c));

                while (q.Count > 0)
                {
                    var (i, j) = q.Dequeue();
                    foreach (var (dr, dc) in dirs)
                    {
                        int ni = i + dr, nj = j + dc;
                        if (ni < 0 || nj < 0 || ni >= m || nj >= n) continue;
                        if (grid[ni][nj] != '1') continue;
                        grid[ni][nj] = '0';
                        q.Enqueue((ni, nj));
                    }
                }
            }
        }
        return islands;
    }
}