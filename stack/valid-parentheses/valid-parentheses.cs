public class Solution
{
    public bool IsValid(string s)
    {
        var pairs = new Dictionary<char, char>
        {
            {')', '('},
            {']', '['},
            {'}', '{'}
        };
        var stack = new Stack<char>();

        foreach (var c in s)
        {
            if (pairs.ContainsKey(c))
            {
                if (stack.Count == 0 || stack.Pop() != pairs[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}