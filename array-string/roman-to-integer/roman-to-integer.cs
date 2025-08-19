public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;
        int prev = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            int value = Val(s[i]);
            result += value < prev ? -value : value;
            prev = value;
        }

        return result;
    }

    private static int Val(char c) => c switch
    {
        'I' => 1,
        'V' => 5,
        'X' => 10,
        'L' => 50,
        'C' => 100,
        'D' => 500,
        'M' => 1000,
        _ => throw new ArgumentException($"Unexpected roman char: '{c}'")
    };
}