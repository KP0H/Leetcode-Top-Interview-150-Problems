public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        var res = new List<int>(matrix.Length * matrix[0].Length);
        int top = 0, bottom = matrix.Length - 1;
        int left = 0, right = matrix[0].Length - 1;

        while (top <= bottom && left <= right)
        {
            for (int c = left; c <= right; c++) res.Add(matrix[top][c]);
            top++;

            for (int r = top; r <= bottom; r++) res.Add(matrix[r][right]);
            right--;

            if (top <= bottom)
            {
                for (int c = right; c >= left; c--) res.Add(matrix[bottom][c]);
                bottom--;
            }
            if (left <= right)
            {
                for (int r = bottom; r >= top; r--) res.Add(matrix[r][left]);
                left++;
            }
        }
        return res;
    }
}