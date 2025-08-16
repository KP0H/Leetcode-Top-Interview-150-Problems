public class Solution
{
    public bool CanConstruct(string ransomNote, string magazine)
    {
        Dictionary<char, int> letters = new Dictionary<char, int>();

        for (int i = 0; i < magazine.Length; i++)
        {
            if (letters.ContainsKey(magazine[i]))
            {
                letters[magazine[i]]++;
            }
            else
            {
                letters.Add(magazine[i], 1);
            }
        }

        for (int i = 0; i < ransomNote.Length; i++)
        {
            if (!letters.ContainsKey(ransomNote[i]))
            {
                return false;
            }

            letters[ransomNote[i]]--;
            if (letters[ransomNote[i]] < 0)
            {
                return false;
            }
        }

        return true;
    }
}