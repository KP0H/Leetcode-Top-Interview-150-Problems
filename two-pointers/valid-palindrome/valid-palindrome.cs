public class Solution
{
    public bool IsPalindrome(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return false;
        }

        for (int left = 0, right = s.Length - 1; left < right;)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if (char.ToLower(s[left++]) != char.ToLower(s[right--]))
            {
                return false;
            }
        }

        return true;
    }
}