public class Solution
{
    public string SimplifyPath(string path)
    {
        var stack = new Stack<string>();
        foreach (var part in path.Split('/', StringSplitOptions.RemoveEmptyEntries))
        {
            if (part == ".") continue;
            if (part == "..") { if (stack.Count > 0) stack.Pop(); }
            else stack.Push(part);
        }
        return "/" + string.Join("/", stack.Reverse());
    }
}
