public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        int[] counts = new int[26];

        foreach (char c in magazine)
        {
            counts[c - 'a']++;
        }

        foreach (char c in ransomNote)
        {
            counts[c - 'a']--;

            if (counts[c - 'a'] < 0)
            {
                return false;
            }
        }

        return true;
    }
}