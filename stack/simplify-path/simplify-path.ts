function simplifyPath(path: string): string {
    const stack: string[] = [];
    for (const part of path.split("/")) {
        if (part === "" || part === ".") continue;
        if (part === "..") { if (stack.length) stack.pop(); }
        else stack.push(part);
    }
    return "/" + stack.join("/");
}
