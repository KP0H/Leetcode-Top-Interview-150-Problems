public class Solution
{
    public bool IsValid(string s)
    {
        if (string.IsNullOrEmpty(s) || s.Length == 1)
        {
            return false;
        }

        var bracketsDict = new Dictionary<char, char>()
        {
            {'(',')'},
            {'{','}'},
            {'[',']'},
        };

        var bracketsStack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (!bracketsStack.TryPeek(out var lastBracket))
            {
                bracketsStack.Push(s[i]);
                continue;
            }

            if (bracketsDict.ContainsKey(s[i]))
            {
                bracketsStack.Push(s[i]);
            }
            else if (bracketsDict[lastBracket] == s[i])
            {
                bracketsStack.Pop();
            }
            else
            {
                return false;
            }
        }

        if (bracketsStack.Count > 0)
        {
            return false;
        }

        return true;
    }
}