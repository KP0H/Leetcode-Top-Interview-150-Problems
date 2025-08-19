public class Solution
{
    public int RomanToInt(string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int value = Val(s[i]);
            if (i + 1 < s.Length && value < Val(s[i + 1]))
            {
                result -= value;
            }
            else
            {
                result += value;
            }
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