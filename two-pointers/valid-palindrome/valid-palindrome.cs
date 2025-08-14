public class Solution
{
    public bool IsPalindrome(string s)
    {
        int i = 0;
        int j = s.Length - 1;

        while (i <= j)
        {
            if (!((s[i] >= '0' && s[i] <= '9') || (s[i] >= 'A' && s[i] <= 'Z') || (s[i] >= 'a' && s[i] <= 'z')))
            {
                i++;
                continue;
            }

            while (!((s[j] >= '0' && s[j] <= '9') || (s[j] >= 'A' && s[j] <= 'Z') || (s[j] >= 'a' && s[j] <= 'z')))
            {
                j--;
            }

            if (char.ToLower(s[i]) != char.ToLower(s[j]))
            {
                return false;
            }

            j--;
            i++;
        }

        return true;
    }
}