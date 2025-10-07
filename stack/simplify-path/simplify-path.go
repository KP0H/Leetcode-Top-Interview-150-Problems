func simplifyPath(path string) string {
    parts := strings.Split(path, "/")
    stack := make([]string, 0, len(parts))
    for _, p := range parts {
        if p == "" || p == "." {
            continue
        } else if p == ".." {
            if len(stack) > 0 {
                stack = stack[:len(stack)-1]
            }
        } else {
            stack = append(stack, p)
        }
    }
    return "/" + strings.Join(stack, "/")
}